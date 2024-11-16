package samplej.BlackJack;

import java.security.SecureRandom;

public class utils {
    public final static String SeperateLine = "------------------------------";
    
    public static void ShuffleCards(Card[] cards) {
        SecureRandom rand = new SecureRandom();
        for (int i = cards.length - 1; i > 0; i--) {
            int j = rand.nextInt(i + 1);
            Card temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }
    }
}
