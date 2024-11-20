package samplej.BlackJack;

import java.util.Scanner;

public class Main {
    private final static String SeperateLine = "------------------------------";
    private static Scanner scanner;

    public static void main(String[] args) {
        System.out.println("Hello world!");
        Joke joke = new Joke();
        //joke.loadJokes();

        scanner = new Scanner(System.in);
        Game game = new Game();
        System.out.println();

        game.setupPlayers();

        boolean continuePlay = true;
        while (continuePlay) {
            game.start();
            System.out.println(SeperateLine);
            System.out.printf("ROUND %d:\n", game.getRound());

            game.setPlayersBet();
            System.out.println();

            game.displayPlayStatus();
            System.out.println();

            game.play();

            System.out.println(SeperateLine);
            game.checkRoundResult();
            System.out.println(game.getRoundResult());
            System.out.print("Do you want to play another round? [Y/N] ");
            String str = scanner.nextLine();
            continuePlay = str.equals("Y") || str.equals("y");
        }

        scanner.close();
    }

    public static void showMessage(String message) {
        System.out.print(message);
    }

    public static void newLine(){
        System.out.println();
    }

    public static String nextLine() {
        return scanner.nextLine();
    }
}
