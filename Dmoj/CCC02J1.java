package Dmoj;

// CCC '02 J1 - 0123456789
public class CCC02J1 {

    public static void main(String[] args) {
        int digital = 9;
        int[][][] symbols = {
            {
                { 0, 1, 0 },
                { 1, 0, 1 },
                { 0, 0, 0 },
                { 1, 0, 1 },
                { 0, 1, 0 }
            },
            {
                { 0, 0, 0 },
                { 0, 0, 1 },
                { 0, 0, 0 },
                { 0, 0, 1 },
                { 0, 0, 0 }
            },
            {
                { 0, 1, 0 },
                { 0, 0, 1 },
                { 0, 1, 0 },
                { 1, 0, 0 },
                { 0, 1, 0 }
            },
            {
                { 0, 1, 0 },
                { 0, 0, 1 },
                { 0, 1, 0 },
                { 0, 0, 1 },
                { 0, 1, 0 }
            },
            {
                { 0, 0, 0 },
                { 1, 0, 1 },
                { 0, 1, 0 },
                { 0, 0, 1 },
                { 0, 0, 0 }
            },
            {
                { 0, 1, 0 },
                { 1, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 1 },
                { 0, 1, 0 }
            },
            {
                { 0, 1, 0 },
                { 1, 0, 0 },
                { 0, 1, 0 },
                { 1, 0, 1 },
                { 0, 1, 0 }
            },
            {
                { 0, 1, 0 },
                { 0, 0, 1 },
                { 0, 0, 0 },
                { 0, 0, 1 },
                { 0, 0, 0 }
            },
            {
                { 0, 1, 0 },
                { 1, 0, 1 },
                { 0, 1, 0 },
                { 1, 0, 1 },
                { 0, 1, 0 }
            },
            {
                { 0, 1, 0 },
                { 1, 0, 1 },
                { 0, 1, 0 },
                { 0, 0, 1 },
                { 0, 1, 0 }
            }
        };
        int[][] nums = symbols[digital];
        for (int i = 0; i < nums.length; i++) {
            String line = "";
            if (i % 2 == 0) {
                for (int j = 0; j < 3; j++) {
                    line = getLine(nums[i][j], line, j);
                }
                line = trimEnd(line) + "\n";
            } else {
                for (int k = 0; k < 3; k++) {
                    for (int j = 0; j < 3; j++) {
                        line = getLine(nums[i][j], line, j);
                    }
                    line = trimEnd(line) + "\n";
                }
            }
            System.out.print(line);
        }
    }

    private static String getLine(int num, String line, int j) {
        if (num == 0) {
            line += (j % 2 == 0) ? " " : "     ";
        } else {
            line += (j % 2 == 0) ? "*" : "* * *";
        }
        return line;
    }
    
    private static String trimEnd(String str) {
        int end = str.length();
        while (end > 0 && str.charAt(end - 1) == ' ') {
            end--;
        }
        return str.substring(0, end);
    }
}
