package BlackJack;

import java.util.ArrayList;

abstract public class PlayerBase {

    public enum PlayStatus {
        Playing, Stand, Bust, BlackJack
    }

    public enum PlayResult {
        Win, Tie, Lost
    }

    protected String name;
    protected double money;
    protected double bet;
    protected ArrayList<Card> cardList;
    protected PlayStatus status;
    protected PlayResult playResult;

    public PlayerBase(String name, double money) {
        this.name = name;
        this.money = money;
        cardList = new ArrayList<>();
        status = PlayStatus.Playing;
        this.playResult = PlayResult.Tie;// Initial a value to avoid null
    }

    public String getName() {
        return name;
    }

    public double getMoney() {
        return money;
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

    public void resetHand() {
        cardList.clear();
        status = PlayStatus.Playing;
    }

    public void hit(Card card) {
        addCard(card);
    }

    public PlayStatus getStatus() {
        return status;
    }

    public boolean isPlaying() {
        return this.status == PlayStatus.Playing;
    }

    public void setIsStand() {
        if (status == PlayStatus.Playing) {
            status = PlayStatus.Stand;
        }
    }

    public boolean isStand() {
        return status == PlayStatus.Stand;
    }

    abstract public String getDisplayInfo(boolean revealResult);
}
