package BlackJack;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

import BlackJack.PlayerBase.PlayStatus;

public class Game {
    private static final int MAX_CARD_COUNT = 52;
    private Card[] cards = new Card[MAX_CARD_COUNT];
    private int cardIndex = 0;
    private Dealer dealer;
    private Player[] players;
    private int round = 0;

    public Game() {
        initializeDeck();
        Main.showMessage(displayDeck());
        shuffleCards();
        dealer = new Dealer();
    }

    // Initializes the deck with 52 cards.
    private void initializeDeck() {
        for (int i = 0; i < MAX_CARD_COUNT; i++) {
            cards[i] = new Card(i);
        }
    }

    // Returns a string representation of the current deck of cards.
    public String displayDeck() {
        StringBuilder result = new StringBuilder();
        for (Card card : cards) {
            result.append(card.toString()).append(" ");
        }
        result.append("\n");
        return result.toString();
    }

    // Shuffles the deck of cards.
    public void shuffleCards() {
        Random rand = new Random();
        for (int i = cards.length - 1; i > 0; i--) {
            int j = rand.nextInt(i + 1);
            Card temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }
        cardIndex = 0; // Reset card index after shuffling
    }

    public void setupPlayers() {
        Main.showMessage("How many players are there? [MAX: 6] ");

        int playerNum = Integer.parseInt(Main.nextLine());
        Main.newLine();
        Player[] players = new Player[playerNum];
        for (int i = 0; i < playerNum; i++) {
            String message = String.format("For player %d:\n  What is their name? ", i + 1);
            Main.showMessage(message);
            String name = Main.nextLine();
            Main.showMessage("  How much money do they have? ");
            double money = Double.parseDouble(Main.nextLine());
            Main.newLine();
            players[i] = new Player(name, money);
        }
        this.players = players;
    }

    public void setPlayersBet() {
        for (var player : this.players) {
            player.setBet();
        }
    }

    // Returns the current round number.
    public int getRound() {
        return round;
    }

    // Gets the next card from the deck, reshuffling if necessary.
    public Card getNextCard() {
        if (cardIndex >= MAX_CARD_COUNT) {
            Main.showMessage("Deck is empty. Reshuffling...\n");
            initializeDeck();
            shuffleCards();
            Main.showMessage(displayDeck());
        }
        return cards[cardIndex++];
    }

    public void start() {
        dealer.resetHand();
        for (Player player : players) {
            player.resetHand();
        }

        for (Player player : players) {
            player.addCard(getNextCard());
            player.addCard(getNextCard());
        }
        dealer.addCard(getNextCard());
        dealer.addCard(getNextCard());

        round++;
        Main.showMessage(displayDeck());
    }

    public void dealerHit() {
        if (isPlaying()) {
            dealer.hit(getNextCard());
        } else {
            while (dealer.shouldHit()) {
                dealer.hit(getNextCard());
            }
        }
    }

    public boolean isPlaying() {
        if (!dealer.isPlaying()) {
            return false;
        }
        for (Player player : players) {
            if (player.getStatus() == PlayStatus.Playing) {
                return true;
            }
        }
        return false;
    }

    public void play() {
        while (isPlaying()) {
            for (var player : this.players) {
                Main.showMessage(player.getDisplayInfo(false));
                if (player.isPlaying()) {
                    Main.showMessage("\nHit or stand? [1 or 2] ");
                    String str = Main.nextLine();
                    if (str.equals("1")) {
                        player.hit(getNextCard());
                    } else if (str.equals("2")) {
                        player.setIsStand();
                    } else {
                        // TODO: Error?
                    }
                }
            }

            dealerHit();

            Main.newLine();
            displayPlayStatus();
            Main.newLine();
        }
    }

    public void displayPlayStatus() {
        Dealer dealer = this.dealer;
        Main.showMessage(dealer.getDisplayInfo(false));
        for (var player : this.players) {
            Main.showMessage(player.getDisplayInfo(false));
        }
        Main.newLine();
    }

    public List<PlayerBase> checkRoundResult() {
        List<PlayerBase> winners = new ArrayList<>();
        int dealerTotal = dealer.getTotal();
        PlayStatus dealerStatus = dealer.getStatus();

        for (var player : players) {
            int playerTotal = player.getTotal();
            PlayStatus playerStatus = player.getStatus();

            if (playerStatus == PlayStatus.Bust) {
                player.lost();
                winners.add(dealer);
            } else if (playerStatus == PlayStatus.BlackJack && dealerStatus != PlayStatus.BlackJack) {
                player.won();
                winners.add(player);
            } else if (playerStatus == PlayStatus.Stand) {
                if (dealerStatus == PlayStatus.Bust || playerTotal > dealerTotal) {
                    player.won();
                    winners.add(player);
                } else if (playerTotal == dealerTotal) {
                    player.tie();
                } else {
                    player.lost();
                    winners.add(dealer);
                }
            }
        }

        return winners;
    }

    // Returns the result of the current round.
    public String getRoundResult() {
        StringBuilder result = new StringBuilder();
        result.append(String.format("ROUND %d RESULTS:\n\n", round));

        result.append("Hands:\n");
        result.append(dealer.getDisplayInfo(true));
        for (Player player : players) {
            result.append(player.getDisplayInfo(true));
        }
        result.append("\n\n");
        for (Player player : players) {
            result.append(String.format("%s: $%.2f\n", player.getName(), player.getMoney()));
        }

        return result.toString().trim();
    }
}
