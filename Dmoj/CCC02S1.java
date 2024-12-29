package Dmoj;

import java.util.*;

// CCC '02 S1 - The Students' Council Breakfast
public class CCC02S1 {
    public static void main(String[] args) {
        String input = """
                1
                2
                3
                4
                3
                """;

        Scanner inp = new Scanner(input);
        int[] grades = new int[4];
        for (int i = 0; i < 4; i++) {
            grades[i] = Integer.parseInt(inp.nextLine());
        }
        int total = Integer.parseInt(inp.nextLine());
        inp.close();
        int[] results = { 0, Integer.MAX_VALUE };
        combine(total, grades, 3, new int[4], results);
        System.out.printf("Total combinations is %d.\n", results[0]);
        System.out.printf("Minimum number of tickets to print is %d.\n", results[1]);
    }

    private static void combine(int reminder, int[] grades, int index, int[] tickets, int[] results) {
        if (reminder == 0) {
            results[0]++;
            int total = 0;
            for (int t : tickets) {
                total += t;
            }
            results[1] = Math.min(total, results[1]);
            System.out.printf("# of PINK is %d # of GREEN is %d # of RED is %d # of ORANGE is %d\n", tickets[0],
                    tickets[1], tickets[2], tickets[3]);
            return;
        }
        if (index < 0)
            return;
        int grade = grades[index];
        for (int i = reminder / grade; i >= 0; i--) {
            tickets[index] = i;
            combine(reminder - grade * i, grades, index - 1, tickets, results);
        }
    }
}