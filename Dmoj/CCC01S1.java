package Dmoj;

import java.util.*;

// CCC '01 S1 - Keeping Score
public class CCC01S1 {
    public static void main(String[] args) {
        Scanner inp = new Scanner("C258TJKD69QAHSTJA");
        String cards = inp.nextLine();
        inp.close();
        System.out.println("Cards Dealt              Points");
        int index = 0;
        int[] total = new int[] { 0 };
        index = printSuit(cards, index + 1, "Clubs", 'D', total);
        index = printSuit(cards, index + 1, "Diamonds", 'H', total);
        index = printSuit(cards, index + 1, "Hearts", 'S', total);
        index = printSuit(cards, index + 1, "Spades", ' ', total);
        System.out.printf("         Total %d\n", total[0]);
    }

    private static int printSuit(String cards, int startIndex, String suitName, char nextType, int[] total) {
        int index = startIndex;
        int points = 0;
        String cardList = "";
        while (index < cards.length()) {
            char c = cards.charAt(index);
            if (c == nextType) {
                break;
            }
            switch (c) {
                case 'A':
                    points += 4;
                    break;
                case 'K':
                    points += 3;
                    break;
                case 'Q':
                    points += 2;
                    break;
                case 'J':
                    points += 1;
                    break;
                default:
                    break;
            }
            cardList += String.copyValueOf(new char[] { ' ', c });
            index++;
        }
        int num = index - startIndex;
        if (num <= 2) {
            points += 3 - num;
        }
        total[0] += points;
        System.out.printf("%s%s   %d\n", suitName, cardList, points);
        return index;
    }
}
