package Dmoj;

import java.util.*;

// CCC '00 S4 - Golf
public class CCC00S4Golf {
    public static void main(String[] args) {
        String input = """
                100
                3
                33
                66
                1
                                """;
        Scanner inp = new Scanner(input);
        int distance = Integer.parseInt(inp.nextLine());
        int clubs = Integer.parseInt(inp.nextLine());
        int[] strokes = new int[clubs];
        for (int i = 0; i < clubs; i++) {
            strokes[i] = Integer.parseInt(inp.nextLine());
        }
        inp.close();
        for (int i = strokes.length - 1; i > 0; i--) {
            boolean flag = false;
            for (int j = 0; j < i; j++) {
                if (strokes[j] > strokes[j + 1]) {
                    int tmp = strokes[j];
                    strokes[j] = strokes[j + 1];
                    strokes[j + 1] = tmp;
                    flag = true;
                }
            }
            if (!flag)
                break;
        }
        Result result = canFindCombination(strokes, distance);
        if (result.found) {
            System.out.printf("Roberta wins in %d strokes.\n", result.minCount);
        } else {
            System.out.println("Roberta acknowledges defeat.");
        }
    }

    static class Result {
        boolean found;
        int minCount;

        Result(boolean found, int minCount) {
            this.found = found;
            this.minCount = minCount;
        }
    }

    static Result canFindCombination(int[] nums, int target) {
        int[] minCount = new int[]{Integer.MAX_VALUE};
        boolean found = backtrackMinCount(nums, target, 0, 0, minCount);
        if (found) {
            return new Result(true, minCount[0]);
        }
        return new Result(false, -1);
    }

    static boolean backtrackMinCount(int[] nums, int target, int start, int count, int[] minCount) {
        if (target == 0) {
            if (count < minCount[0]) {
                minCount[0] = count;
            }
            return true;
        }

        boolean found = false;
        for (int i = start; i < nums.length; i++) {
            if (nums[i] > target) {
                break;
            }
            found |= backtrackMinCount(nums, target - nums[i], i + 1, count + 1, minCount);
        }
        return found;
    }
}
