package Dmoj;

import java.util.*;;

// CCC '03 J1 - Trident
public class CCC03J1 {
    public static void main(String[] args) {
        String input = """
                4
                3
                2
                """;
        Scanner inp = new Scanner(input);
        int t = Integer.parseInt(inp.nextLine());
        int s = Integer.parseInt(inp.nextLine());
        int h = Integer.parseInt(inp.nextLine());
        inp.close();

        for (int i = 0; i < t; i++) {
            System.out.println("*" + " ".repeat(s) + "*" + " ".repeat(s) + "*");
        }
        System.out.println("*".repeat(3 + 2 * s));
        for (int i = 0; i < h; i++) {
            System.out.println(" ".repeat(1 + s) + "*");
        }
    }
}
