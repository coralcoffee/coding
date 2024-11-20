package samplej.BlackJack;

import java.util.Scanner;

public class Main {
    private final static String SeperateLine = "------------------------------";

    public static void main(String[] args) {
        Scanner inp = new Scanner(System.in);
        Game game = new Game();
        System.out.println(game.displayDeck());

        setupPlayers(inp, game);

        boolean continuePlay = true;
        while (continuePlay) {
            game.play();
            System.out.printf("ROUND %d:\n", game.getRound());

            getPlayersBet(inp, game);

            displayPlayStatus(game);

            while (game.isPlaying()) {
                for (var player : game.getPlayers()) {
                    if (player.isPlaying()) {
                        System.out.println(player.getDisplayInfo(false));
                        System.out.print("Hit or stand? [1 or 2] ");
                        String str = inp.nextLine();
                        if (str.equals("1")) {
                            player.hit(game.getNextCard());
                        } else if (str.equals("2")) {
                            player.setIsStand();
                        } else {
                            // TODO: Error?
                        }
                    }
                }

                game.dealerHit();

                System.out.println();
                displayPlayStatus(game);
            }
            System.out.println(SeperateLine);
            game.checkRoundResult();
            System.out.println(game.getRoundResult());
            System.out.print("Do you want to play another round? [Y/N] ");
            String str = inp.nextLine();
            continuePlay = str.equals("Y") || str.equals("y");
        }

        inp.close();
    }

    private static void setupPlayers(Scanner inp, Game game) {
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
    }

    private static void getPlayersBet(Scanner inp, Game game) {
        for (var player : game.getPlayers()) {
            boolean validBet = false;
            double bet = 0.0;

            while (!validBet) {
                System.out.printf("%s's wager [$%.2f]: ", player.getName(), player.getMoney());
                bet = Double.parseDouble(inp.nextLine());

                if (player.setBet(bet)) {
                    validBet = true; // Bid is valid and successfully set
                } else {
                    System.out.println("You don't have enough money for that. Please enter a lower wager.");
                }
            }
            System.out.println();
        }
    }

    static void displayPlayStatus(Game game) {
        Dealer dealer = game.getDealer();
        System.out.println(dealer.getDisplayInfo(false));
        for (var player : game.getPlayers()) {
            System.out.println(player.getDisplayInfo(false));
        }
        System.out.println();
        System.out.println();
    }
}
