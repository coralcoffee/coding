package Dmoj;

import java.util.*;

// CCC '01 J2 - Mod Inverse
public class CCC01J2 {
    public static void main(String[] args) {
        String input = """
                4
                133
                            """;
        Scanner inp = new Scanner(input);
        int x = Integer.parseInt(inp.nextLine());
        int m = Integer.parseInt(inp.nextLine());
        inp.close();
        int n = m / x;
        while (n < m && x * n % m != 1) {
            n++;
        }
        if (n < m) {
            System.out.println(n);
        } else {
            System.out.println("No such integer exists.");
        }
    }
}