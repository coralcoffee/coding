package BlackJack;

public class Player extends PlayerBase {
    public Player(String name, double money) {
        super(name, money);
    }

    public void won() {
        resolveBet(PlayResult.Win);
    }

    public void tie() {
        resolveBet(PlayResult.Tie);
    }

    public void lost() {
        resolveBet(PlayResult.Lost);
    }

    public void resolveBet(PlayResult result) {
        switch (result) {
            case Win:
                money += bet * 2;
                break;
            case Tie:
                money += bet;
                break;
            case Lost:
                break;
        }
        bet = 0;
        playResult = result;
    }

    public void setBet() {
        boolean validBet = false;
        double bet = 0.0;

        while (!validBet) {
            Main.showMessage(String.format("%s's wager [$%.2f]: ", this.name, this.money));
            bet = Double.parseDouble(Main.nextLine());
            if (bet > money) {
                Main.showMessage("You don't have enough money for that. Please enter a lower wager.\n");
            } else {
                this.bet = bet;
                this.money -= bet;
                validBet = true;
            }
        }
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
