package samplej.BlackJack;

public class Card {
    final static char hearts = '\u2665';
    final static char diamonds = '\u2666';
    final static char spades = '\u2660';
    final static char clubs = '\u2663';
    final static char[] suits = { hearts, diamonds, clubs, spades };

    private int index;
    private int value;
    private char suit;
    private String card;

    public Card(int index) {
        this.index = index;
        int d = index / 13;
        int m = index % 13;
        suit = Card.suits[d];
        value = m == 0 ? 10 : m;
        switch (m) {
            case 0:
                card = "K";
                break;
            case 1:
                card = "A";
                break;
            case 11:
                card = "J";
                break;
            case 12:
                card = "Q";
                break;
            default:
                card = String.valueOf(m);
                break;
        }
    }

    public int getIndex() {
        return index;
    }

    public int getValue() {
        return value;
    }

    public char getSuit() {
        return suit;
    }

    public String getCard() {
        return card;
    }

    @Override
    public String toString() {
        return String.format("%s%s", card, suit);
    }
}
