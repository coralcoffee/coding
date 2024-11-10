package Dmoj;

import java.util.*;

// CCC '04 S1 - Fix
public class CCC04S1 {
    public static void main(String[] args) {
        String input = """
                2
                abba
                aab
                bab
                a
                ab
                aa
                """;
        Scanner inp = new Scanner(input);
        int n = Integer.parseInt(inp.nextLine());
        while (n > 0) {
            String prefix = inp.nextLine();
            String sufix = inp.nextLine();
            String str = inp.nextLine();
            boolean result = str.indexOf(prefix) == 0 || str.indexOf(sufix) == str.length() - sufix.length();
            System.out.println(result ?  "No":"Yes");
            n--;
        }
        inp.close();
    }
}
