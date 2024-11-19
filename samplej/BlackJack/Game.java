package samplej.BlackJack;

import java.util.Random;

public class Game {
    private Card[] cards = new Card[52];
    private int cardIndex = 0;
    private Dealer dealer;
    private Player[] players;
    private int round = 1;

    public Game() {
        for (int i = 0; i < 52; i++) {
            cards[i] = new Card(i);
        }
        dealer = new Dealer();
    }

    public String getDeckOfCards() {
        String result = "";
        for (int i = 0; i < 52; i++) {
            result += " " + cards[i].toString();
        }
        return result;
    }

    public void shuffleCards() {
        var rand = new Random();
        for (int i = cards.length - 1; i > 0; i--) {
            int j = rand.nextInt(i + 1);
            Card temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }
    }

    public void setPlayers(Player[] players) {
        this.players = players;
    }

    public Player[] getPlayers() {
        return players;
    }

    public Dealer getDealer() {
        return dealer;
    }

    public int getRound() {
        return round;
    }

    public Card getNextCard() {
        return cards[cardIndex++];
    }

    public void play() {
        round++;
        // TODO: dealer and player, who get the card first?
        for (var player : players) {
            player.deal();
            player.addCard(getNextCard());
            player.addCard(getNextCard());
        }
        dealer.deal();
        dealer.addCard(getNextCard());
        dealer.addCard(getNextCard());
    }

    public String getRoundResult() {
        String result = String.format("ROUND %d RESULTS:\n\n", round);

        result += "Hands:\n";
        result += dealer.getDisplayInfo() + "\n";
        for (Player player : players) {
            result += player.getDisplayInfo() + "\n";
        }

        result += "\n";
        for (Player player : players) {
            result += String.format("%s: $%.2f", player.getName(), player.getMoney());
        }
        return result;
    }
}