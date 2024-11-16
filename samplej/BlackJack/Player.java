package samplej.BlackJack;

import java.util.ArrayList;

public class Player {
    enum PlayerType {
        Player,
        Dealer,
    }

    private String name;
    private double money;
    private double bid;
    private ArrayList<Card> cardList;
    private PlayerType playerType;

    public Player(String name, double money, PlayerType playerType) {
        this.name = name;
        this.money = money;
        this.playerType = playerType;
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

    public void setBid(double bid) {
        if (bid > money) {
            System.out.println("You don't have enough money for that.");
            return;
        }
        this.bid = bid;
    }

    public void addCard(Card card) {
        cardList.add(card);
    }

    public String getDisplayInfo() {
        String result = String.format("%s's hand: ", name);
        int total = 0;
        for (int i = 0; i < cardList.size(); i++) {
            var card = cardList.get(i);
            if (i == 0 && playerType == PlayerType.Dealer) {
                result += " ?";
            } else {
                result += " " + card.toString();
            }
            total += card.getValue();
        }
        return result + String.format(" [total: %d]", total);
    }
}
