package samplej.BlackJack;

public class Card {
    public static final char HEARTS = '♥';
    public static final char DIAMONDS = '♦';
    public static final char SPADES = '♠';
    public static final char CLUBS = '♣';
    public static final char[] SUITS = { HEARTS, DIAMONDS, CLUBS, SPADES };

    private int index;
    private int value;
    private char suit;
    private String rank;

    public Card(int index) {
        this.index = index;
        int d = index / 13;
        int m = index % 13;

        suit = Card.SUITS[d];
        value = (m > 0 && m <= 10) ? m : 10;
        switch (m) {
            case 0:
                rank = "K";
                break;
            case 1:
                rank = "A";
                break;
            case 11:
                rank = "J";
                break;
            case 12:
                rank = "Q";
                break;
            default:
                rank = String.valueOf(m);
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

    public String getRank() {
        return rank;
    }

    @Override
    public String toString() {
        return String.format("%s%s", rank, suit);
    }
}
