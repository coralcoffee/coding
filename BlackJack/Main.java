package BlackJack;

import java.util.Scanner;

public class Main {
    private final static String SeperateLine = "------------------------------";
    private static Scanner scanner;

    public static void main(String[] args) {
        scanner = new Scanner(System.in);
        Game game = new Game();
        newLine();

        game.setupPlayers();

        boolean continuePlay = true;
        while (continuePlay) {
            game.start();
            System.out.println(SeperateLine);
            System.out.printf("ROUND %d:\n", game.getRound());
            newLine();
            game.setPlayersBet();
            newLine();

            game.displayPlayStatus();
            newLine();

            game.play();

            System.out.println(SeperateLine);
            var winners = game.checkRoundResult();
            System.out.println(game.getRoundResult());

            newLine();
            for (var winner : winners) {
                showMessage(String.format("%s says: \"%s\"\n", winner.getName(), Joke.nextJoke()));
            }
            newLine();
            System.out.print("Do you want to play another round? [Y/N] ");
            String str = scanner.nextLine();
            continuePlay = str.equals("Y") || str.equals("y");
        }

        scanner.close();
    }

    public static void showMessage(String message) {
        System.out.print(message);
    }

    public static void newLine() {
        System.out.println();
    }

    public static String nextLine() {
        return scanner.nextLine();
    }
}
