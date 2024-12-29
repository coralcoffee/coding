package Dmoj;

import java.util.*;

// CCC '01 J1 - Dressing Up
public class CCC01J1 {
    public static void main(String[] args) {
        String input = """
                5
                """;
        Scanner inp = new Scanner(input);
        int height = Integer.parseInt(inp.nextLine());
        inp.close();
        String output = "";
        int half = height / 2;
        for (int i = 0; i < height; i++) {
            int width = i <= half ? 2 * i + 1 : 2 * (height - i) - 1;
            String line = "*".repeat(width);
            output += line + " ".repeat((height - width) * 2) + line + "\n";
        }
        System.out.print(output);
    }
}
