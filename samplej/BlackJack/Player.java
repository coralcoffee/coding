package samplej.BlackJack;

public class Player extends PlayerBase {
    public Player(String name, double money) {
        super(name, money);
    }

    public void won() {
        if (status == PlayStatus.BlackJack) {
            this.money += this.bet * 5 / 2;
        } else {
            this.money += this.bet * 2;
        }
        this.bet = 0;
        playResult = PlayResult.Win;
    }

    public void tie() {
        playResult = PlayResult.Tie;
        this.money += this.bet;
        this.bet = 0;
    }

    public void lost() {
        this.bet = 0;
        playResult = PlayResult.Lost;
    }

    @Override
    public String getDisplayInfo(boolean revealResult) {
        StringBuilder result = new StringBuilder(String.format("%s's hand: ", name));
        for (Card card : cardList) {
            result.append(" ").append(card.toString());
        }
        result.append(String.format(" [total: %d]", getTotal()));
        if (revealResult) {
            switch (this.playResult) {
                case Win:
                    result.append(" Winner!");
                    break;
                case Lost:
                    result.append(" Lost!");
                    break;
                case Tie:
                    result.append(" Tie!");
                    break;
                default:
                    break;
            }
        } else if (status == PlayStatus.BlackJack) {
            result.append("\n" + name + " has Blackjack!");
        }
        return result.toString();
    }
}
