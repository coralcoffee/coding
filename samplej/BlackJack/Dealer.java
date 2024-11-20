package samplej.BlackJack;

public class Dealer extends Player {
    public Dealer() {
        super("Dealer", Double.MAX_VALUE);
    }

    @Override
    public String getDisplayInfo() {
        StringBuilder result = new StringBuilder(String.format("%s's hand:", name));
        for (int i = 0; i < cardList.size(); i++) {
            if (i == 1 && status == PlayStatus.Playing) {
                result.append(" ?");
            } else {
                result.append(" ").append(cardList.get(i).toString());
            }
        }
        return result.toString();
    }

    @Override
    public boolean getIsPlaying() {
        return getTotal() <= 16;
    }
}
