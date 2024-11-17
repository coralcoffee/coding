package samplej.BlackJack;

import java.util.ArrayList;

public class Player {
    public enum PlayStatus {
        Playing, Stand, Bust, Lost, BlackJack
    }

    protected String name;
    private double money;
    private double bid;
    protected ArrayList<Card> cardList;
    protected int total;
    private boolean isStand = false;
    protected PlayStatus status;

    public Player(String name, double money) {
        this.name = name;
        this.money = money;
        cardList = new ArrayList<>();
    }

    public String getName() {
        return name;
    }

    public double getMoney() {
        return money;
    }

    public double getBid() {
        return bid;
    }

    public boolean setBid(double bid) {
        if (bid > money) {
            return false;
        }
        this.bid = bid;
        return true;
    }

    public void addCard(Card card) {
        cardList.add(card);
        total += card.getValue();
        if (total > 21) {
            isStand = true;
            status = PlayStatus.Bust;
        }
    }

    public void deal() {
        cardList.clear();
        total = 0;
        status = PlayStatus.Playing;
    }

    public void hit(Card card) {
        addCard(card);
    }

    public boolean getIsStand() {
        return isStand;
    }

    public void setIsStand() {
        this.isStand = true;
    }

    public String getDisplayInfo() {
        String result = String.format("%s's hand: ", name);
        for (int i = 0; i < cardList.size(); i++) {
            var card = cardList.get(i);
            result += " " + card.toString();
        }
        return result + String.format(" [total: %d]", total);
    }
}
