package samplej.BlackJack;

public class Dealer extends PlayerBase {
    public Dealer() {
        super("Dealer", Double.MAX_VALUE);
    }

    @Override
    public String getDisplayInfo(boolean revealResult) {
        StringBuilder result = new StringBuilder(String.format("%s's hand:", name));
        for (int i = 0; i < cardList.size(); i++) {
            if (!revealResult && i == 1 && status == PlayStatus.Playing) {
                result.append(" ?");
            } else {
                result.append(" ").append(cardList.get(i).toString());
            }
        }
        if (revealResult) {
            result.append(String.format(" [total: %d]", getTotal()));
        }
        return result.toString();
    }

    public boolean shouldHit() {
        return getTotal() <= 16;
    }
}
