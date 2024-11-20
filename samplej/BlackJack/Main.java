package samplej.BlackJack;

import java.util.Scanner;

public class Main {
    private final static String SeperateLine = "------------------------------";
    public static void main(String[] args) {
        Scanner inp = new Scanner(System.in);
        Game game = new Game();
        System.out.println(game.getDeckOfCards());
        game.shuffleCards();
        System.out.println(game.getDeckOfCards());

        System.out.print("How many players are there? [MAX: 6] ");

        int playerNum = Integer.parseInt(inp.nextLine());
        Player[] players = new Player[playerNum];
        for (int i = 0; i < playerNum; i++) {
            System.out.printf("For player %d:\n", i + 1);
            System.out.print("  What is their name? ");
            String name = inp.nextLine();
            System.out.print("  How much money do they have? ");
            double money = Double.parseDouble(inp.nextLine());
            players[i] = new Player(name, money);
        }
        game.setPlayers(players);
        System.out.println(SeperateLine);

        boolean continuePlay = true;
        // int cardIndex = 0;
        while (continuePlay) {
            game.play();
            System.out.printf("ROUND %d:\n", game.getRound());

            getPlayersBid(inp, game);

            displayPlayStatus(game);

            boolean isPlaying = true;
            while (isPlaying) {
                isPlaying = false;
                for (var player : game.getPlayers()) {
                    if (!player.getIsPlaying()) {
                        System.out.println(player.getDisplayInfo());
                        System.out.print("Hit or stand? [1 or 2] ");
                        String str = inp.nextLine();
                        if (str.equals("1")) {
                            player.hit(game.getNextCard());
                            isPlaying = true;
                        } else if (str.equals("2")) {
                            player.setIsStand();
                        } else {
                            // TODO: Error?
                        }
                    }
                }

                Dealer dealer = game.getDealer();
                if (!dealer.getIsPlaying()) {
                    dealer.hit(game.getNextCard());
                }
                System.out.println();
                displayPlayStatus(game);
            }
            System.out.println("compoelted");
            System.out.println(SeperateLine);
            System.out.println(game.getRoundResult());
            System.out.print("Do you want to play another round? [Y/N] ");
            String str = inp.nextLine();
            continuePlay = str.equals("Y") || str.equals("y");
        }

        inp.close();
    }

    private static void getPlayersBid(Scanner inp, Game game) {
        for (var player : game.getPlayers()) {
            boolean validBid = false;
            double bid = 0.0;

            while (!validBid) {
                System.out.printf("%s's wager [$%.2f]: ", player.getName(), player.getMoney());
                bid = Double.parseDouble(inp.nextLine());

                if (player.setBet(bid)) {
                    validBid = true; // Bid is valid and successfully set
                } else {
                    System.out.println("You don't have enough money for that. Please enter a lower wager.");
                }
            }
            System.out.println();
        }
    }

    static void displayPlayStatus(Game game) {
        Dealer dealer = game.getDealer();
        System.out.println(dealer.getDisplayInfo());
        for (var player : game.getPlayers()) {
            System.out.println(player.getDisplayInfo());
        }
        System.out.println();
        System.out.println();
    }
}
