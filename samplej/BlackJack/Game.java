package samplej.BlackJack;

import java.util.Random;

public class Game {
    private static final int CARD_MAX = 52;
    private Card[] cards = new Card[CARD_MAX];
    private int cardIndex = 0;
    private Dealer dealer;
    private Player[] players;
    private int round = 1;

    public Game() {
        initializeDeck();
        dealer = new Dealer();
    }

    // Initializes the deck with 52 cards.
    private void initializeDeck() {
        for (int i = 0; i < CARD_MAX; i++) {
            cards[i] = new Card(i);
        }
    }

    // Returns a string representation of the current deck of cards.
    public String getDeckOfCards() {
        StringBuilder result = new StringBuilder();
        for (Card card : cards) {
            result.append(card.toString()).append(" ");
        }
        return result.toString().trim();
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
    }

    // Sets the players for the game.
    public void setPlayers(Player[] players) {
        this.players = players;
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
        if (cardIndex >= CARD_MAX) {
            shuffleCards();
            cardIndex = 0;
        }
        return cards[cardIndex++];
    }

    // Deals cards and starts a new round.
    public void play() {
        // Reset dealer and player hands before starting the new round.
        dealer.deal();
        for (Player player : players) {
            player.deal();
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

    // Returns the result of the current round.
    public String getRoundResult() {
        StringBuilder result = new StringBuilder();
        result.append(String.format("ROUND %d RESULTS:\n\n", round - 1));

        result.append("Hands:\n");
        result.append(dealer.getDisplayInfo()).append("\n");
        for (Player player : players) {
            result.append(player.getDisplayInfo()).append("\n");
        }

        result.append("\n");
        for (Player player : players) {
            result.append(String.format("%s: $%.2f\n", player.getName(), player.getMoney()));
        }

        return result.toString().trim();
    }
}
