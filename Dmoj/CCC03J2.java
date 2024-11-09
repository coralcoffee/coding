package Dmoj;

import java.util.*;

// CCC '03 J2 - Picture Perfect
public class CCC03J2 {
    public static void main(String[] args) {
        String input = """
                100
                15
                195
                0
                                """;
        Scanner inp = new Scanner(input);
        int c = Integer.parseInt(inp.nextLine());
        while (c != 0) {
            int w = (int) Math.sqrt(c);
            int h = c / w;
            System.out.printf("Minimum perimeter is %d with dimensions %d x %d\n", 2 * (w + h), w, h);
            c = Integer.parseInt(inp.nextLine());
        }
        inp.close();
    }
}