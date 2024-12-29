package Dmoj;

import java.util.*;

// CCC '02 S2 - Fraction Action
public class CCC02S2 {
    public static void main(String[] args) {
        String input = """
                12
                42
                """;
        Scanner inp = new Scanner(input);
        int num1 = Integer.parseInt(inp.nextLine());
        int num2 = Integer.parseInt(inp.nextLine());
        inp.close();
        int v = num1 / num2;
        int f = num1 % num2;
        if (f == 0) {
            System.out.println(v);
        } else {
            if (v != 0) {
                System.out.printf("%d ", v);
            }
            int g = gcd(num2, f);
            System.out.printf("%d/%d\n", f / g, num2 / g);
        }
    }

    private static int gcd(int num1, int num2) {
        if (num1 < num2)
            return gcd(num2, num1);

        if (num2 == 0)
            return num1;

        return gcd(num2, num1 % num2);
    }
}
