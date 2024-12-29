package Dmoj;

import java.util.*;

// CCC '02 J2 - AmeriCanadian
public class CCC02J2 {

    public static void main(String[] args) {
        String input = """
                color
                for
                taylor
                quit!
                """;
        HashSet<Character> vowels = new HashSet<>(Arrays.asList('a', 'e', 'i', 'o', 'u', 'y'));
        Scanner inp = new Scanner(input);
        String word = inp.nextLine();
        while (!word.equals("quit!")) {
            int length = word.length();
            if (length > 4
                    && !vowels.contains(word.charAt(length - 3))
                    && word.substring(length - 2).equals("or")) {
                System.out.println(word.substring(0, length - 2) + "our");
            } else {
                System.out.println(word);
            }
            word = inp.nextLine();
        }
        inp.close();
    }
}