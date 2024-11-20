package samplej.BlackJack;

import java.util.Random;

import samplej.BlackJack.PlayerBase.PlayStatus;

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
        Main.showMessage(displayDeck());
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

    // Returns the players in the game.
    public Player[] getPlayers() {
        return players;
    }

    // Returns the dealer of the game.
    public Dealer getDealer() {
        return dealer;
    }

    // Returns the current round number.
    public int getRound() {
        return round;
    }

    // Gets the next card from the deck, reshuffling if necessary.
    public Card getNextCard() {
        if (cardIndex >= MAX_CARD_COUNT) {
            initializeDeck();
            shuffleCards();
        }
        return cards[cardIndex++];
    }

    // Deals cards and starts a new round.
    public void start() {
        // Reset dealer and player hands before starting the new round.
        dealer.resetHand();
        for (Player player : players) {
            player.resetHand();
        }

        // Deal two cards to each player and the dealer.
        for (Player player : players) {
            player.addCard(getNextCard());
            player.addCard(getNextCard());
        }
        dealer.addCard(getNextCard());
        dealer.addCard(getNextCard());

        // Increment round after the cards are dealt.
        round++;
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
        Main.showMessage(dealer.getDisplayInfo(false) + "\n");
        for (var player : this.players) {
            Main.showMessage(player.getDisplayInfo(false) + "\n");
        }
    }

    public void checkRoundResult() {
        for (var player : players) {
            var status = player.getStatus();
            switch (status) {
                case Bust:
                    player.lost();
                    break;
                case Stand:
                    if (dealer.getStatus() == PlayStatus.Bust) {
                        player.won();
                        break;
                    }
                    int playerTotal = player.getTotal();
                    int dealerTotal = dealer.getTotal();
                    if (playerTotal == dealerTotal) {
                        player.tie();
                    } else if (playerTotal > dealerTotal) {
                        player.won();
                    } else {
                        player.lost();
                    }
                    break;
                case BlackJack:
                    if (dealer.getStatus() == PlayStatus.BlackJack) {
                        player.tie();
                    } else {
                        player.won();
                    }
                    break;
                default:
                    break;
            }
        }
    }

    // Returns the result of the current round.
    public String getRoundResult() {
        StringBuilder result = new StringBuilder();
        result.append(String.format("ROUND %d RESULTS:\n\n", round));

        result.append("Hands:\n");
        result.append(dealer.getDisplayInfo(true)).append("\n");
        for (Player player : players) {
            result.append(player.getDisplayInfo(true)).append("\n");
        }

        result.append("\n");
        for (Player player : players) {
            result.append(String.format("%s: $%.2f\n", player.getName(), player.getMoney()));
        }

        return result.toString().trim();
    }
}
