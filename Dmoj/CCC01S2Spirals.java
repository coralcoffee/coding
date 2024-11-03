package Dmoj;

import java.util.*;

// CCC '01 S2 - Spirals
public class CCC01S2Spirals {
    public static void main(String[] args) {
        String input = """
                1
                71
                """;
        Scanner inp = new Scanner(input);
        int x = Integer.parseInt(inp.nextLine());
        int y = Integer.parseInt(inp.nextLine());
        inp.close();

        int length = y - x + 1;

        int dimension = (int) Math.ceil(Math.sqrt(length));
        if (dimension % 2 == 0)
            dimension++;

        int[][] nums = new int[dimension][dimension];
        int indexX = (dimension) / 2, indexY = (dimension) / 2;
        int step = 1;
        int direction = 1;
        nums[indexX][indexY] = x;
        x++;
        while (x <= y) {
            for (int i = 0; i < step && x <= y; i++) {
                indexX += direction;
                nums[indexX][indexY] = x;
                x++;
            }
            for (int i = 0; i < step && x <= y; i++) {
                indexY += direction;
                nums[indexX][indexY] = x;
                x++;
            }
            direction *= -1;
            step++;
        }

        for (int i = 0; i < dimension; i++) {
            for (int j = 0; j < dimension; j++) {
                //if (nums[i][j] != 0)
                    System.out.printf(" %2d", nums[i][j]);
                //else
                    //System.out.printf("%2s", " ");
            }
            System.out.println();
        }
    }
}
