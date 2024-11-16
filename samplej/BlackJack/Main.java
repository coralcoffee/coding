package samplej.BlackJack;

import java.util.Scanner;

import samplej.BlackJack.Player.PlayerType;

public class Main {
    public static void main(String[] args) {
        Scanner inp = new Scanner(System.in);
        Card[] cards = new Card[52];
        String output = "";
        for (int i = 0; i < 52; i++) {
            cards[i] = new Card(i);
            output += " " + cards[i].toString();
        }
        System.out.println(output);
        System.out.print("How many players are there? [MAX: 6] ");

        int playerNum = Integer.parseInt(inp.nextLine());
        Player[] players = new Player[playerNum];
        for (int i = 0; i < playerNum; i++) {
            System.out.printf("For player %d:\n", i + 1);
            System.out.print("  What is their name? ");
            String name = inp.nextLine();
            System.out.print("  How much money do they have? ");
            double money = Double.parseDouble(inp.nextLine());
            players[i] = new Player(name, money, PlayerType.Player);
        }
        System.out.println(utils.SeperateLine);

        utils.ShuffleCards(cards);

        boolean continuePlay = true;
        int round = 1;
        int cardIndex = 0;
        while (continuePlay) {
            System.out.printf("ROUND %d:\n", round);

            for (var player : players) {
                System.out.printf("%s's wager [$%.2f]: ", player.getName(), player.getMoney());
                double bid = Double.parseDouble(inp.nextLine());
                player.setBid(bid);
                player.addCard(cards[cardIndex++]);
                player.addCard(cards[cardIndex++]);
                System.out.println();
            }
            // TODO: Check dealer and player, who get the card first?
            var dealer = new Player("Dealer", Double.MAX_VALUE, PlayerType.Dealer);
            dealer.addCard(cards[cardIndex++]);
            dealer.addCard(cards[cardIndex++]);

            System.out.println(dealer.getDisplayInfo());
            for (var player : players) {
                System.out.println(player.getDisplayInfo());
            }
//7)	Don’t ask the dealer if he/she would like to hit or stand. Decide using some casino rules - for example higher than 16 - stand, 16 or below hit.

            System.out.print("Do you want to play another round? [Y/N] ");
            String s = inp.nextLine();
            continuePlay = s.equals("Y") || s.equals("y");
            round++;
        }
    }
}
