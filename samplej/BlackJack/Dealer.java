package samplej.BlackJack;

public class Dealer extends Player {
    public Dealer() {
        super("Dealer", Double.MAX_VALUE);
    }

    @Override
    public String getDisplayInfo() {
        String result = String.format("%s's hand:", name);
        for (int i = 0; i < cardList.size(); i++) {
            var card = cardList.get(i);
            if (i == 1) {
                result += " ?";
            } else {
                result += " " + card.toString();
            }
        }
        return result;
        //return result + String.format(" [total: %d]", total);
    }

    @Override
    public boolean getIsStand()
    {
        return total > 16;
    }
}
