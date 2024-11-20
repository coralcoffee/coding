package samplej.BlackJack;

import java.util.ArrayList;

public class Player {
    public enum PlayStatus {
        Playing, Stand, Bust, BlackJack
    }

    protected String name;
    private double money;
    private double bet;
    protected ArrayList<Card> cardList;
    protected PlayStatus status;

    public Player(String name, double money) {
        this.name = name;
        this.money = money;
        cardList = new ArrayList<>();
        status = PlayStatus.Playing;
    }

    public String getName() {
        return name;
    }

    public double getMoney() {
        return money;
    }

    public double getBet() {
        return bet;
    }

    public boolean setBet(double bet) {
        if (bet > money) {
            return false;
        }
        this.bet = bet;
        this.money -= bet;
        return true;
    }

    public void won() {
        if (status == PlayStatus.BlackJack) {
            this.money += this.bet * 3 / 2;
        } else {
            this.money += this.bet;
        }
    }

    public void addCard(Card card) {
        cardList.add(card);
        updateTotalAndStatus();
    }

    private void updateTotalAndStatus() {
        int total = getTotal();
        if (cardList.size() == 2 && total == 21) {
            status = PlayStatus.BlackJack;
        } else if (total > 21) {
            status = PlayStatus.Bust;
        }
    }

    public int getTotal() {
        int total = 0;
        int aceCount = 0;

        for (Card card : cardList) {
            int value = card.getValue();
            if (card.getRank().equals("A")) {
                aceCount++;
            } else {
                total += value;
            }
        }

        // Add aces in the most advantageous way
        for (int i = 0; i < aceCount; i++) {
            if (total + 11 <= 21) {
                total += 11;
            } else {
                total += 1;
            }
        }

        return total;
    }

    public void deal() {
        cardList.clear();
        status = PlayStatus.Playing;
    }

    public void hit(Card card) {
        addCard(card);
    }

    public boolean getIsPlaying() {
        return status == PlayStatus.Playing;
    }

    public void setIsStand() {
        status = PlayStatus.Stand;
    }

    public String getDisplayInfo() {
        StringBuilder result = new StringBuilder(String.format("%s's hand: ", name));
        for (Card card : cardList) {
            result.append(" ").append(card.toString());
        }
        return result.append(String.format(" [total: %d]", getTotal())).toString();
    }
}
