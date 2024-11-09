package Dmoj;

import java.util.*;

// CCC '01 S2 - Spirals (Exact Version)
public class CCC01S2ExactVersion {
    public static void main(String[] args) {
        String input = """
                2
                1 99
                1 10
                """;
        Scanner inp = new Scanner(input);
        int t = Integer.parseInt(inp.nextLine());
        for (int i = 0; i < t; i++) {
            int x = inp.nextInt();
            int y = inp.nextInt();
            inp.nextLine();
            displaySpirals(x, y);
            if (i < t - 1) {
                System.out.println();
            }
        }
        inp.close();
    }

    private static void displaySpirals(int x, int y) {
        int length = y - x + 1;

        int dimension = (int) Math.ceil(Math.sqrt(length));
        if (dimension % 2 == 0)
            dimension++;

        int[][] nums = new int[dimension][dimension];
        int indexX = dimension / 2, indexY = dimension / 2;
        int step = 1;
        int direction = 1;
        nums[indexX][indexY] = x++;

        while (x <= y) {
            for (int i = 0; i < step && x <= y; i++) {
                indexX += direction;
                nums[indexX][indexY] = x++;
            }
            for (int i = 0; i < step && x <= y; i++) {
                indexY += direction;
                nums[indexX][indexY] = x++;
            }
            direction *= -1;
            step++;
        }
        int startX = 1;
        for (int i = 0; i < dimension; i++) {
            if (nums[0][i] != 0) {
                startX = 0;
                break;
            }
        }
        int endX = dimension - 2;
        for (int i = 0; i < dimension; i++) {
            if (nums[dimension - 1][i] != 0) {
                endX = dimension - 1;
                break;
            }
        }
        int startY = 1;
        for (int i = 0; i < dimension; i++) {
            if (nums[i][0] != 0) {
                startY = 0;
                break;
            }
        }
        int endY = dimension - 2;
        for (int i = 0; i < dimension; i++) {
            if (nums[i][dimension - 1] != 0) {
                endY = dimension - 1;
                break;
            }
        }
        int[] numWidth = new int[dimension];
        for (int j = startY; j <= endY; j++) {
            numWidth[j] = 1;
            for (int i = startX; i <= endX; i++) {
                if (nums[i][j] >= 10) {
                    numWidth[j] = 2;
                    break;
                }
            }
        }
        for (int i = startX; i <= endX; i++) {
            for (int j = startY; j <= endY; j++) {
                if (nums[i][j] != 0) {
                    System.out.printf("%" + numWidth[j] + "d", nums[i][j]);
                } else {
                    System.out.print(" ".repeat(numWidth[j]));
                }
                if (j != endY)
                    System.out.print(" ");
            }
            System.out.println();
        }
    }
}
