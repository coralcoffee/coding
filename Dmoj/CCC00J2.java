package Dmoj;

import java.util.Scanner;

public class CCC00J2 {
    public static void main(String[] args) {
        Scanner inp = new Scanner(System.in);
        int start = Integer.parseInt(inp.nextLine());
        int end = Integer.parseInt(inp.nextLine());
        inp.close();
        int result = 0;
        for (int i = start; i <= end; i++) {
            if (isStrobogrammatic(i)) {
                result++;
            }
        }
        System.out.println(result);
    }

    private static boolean isStrobogrammatic(int num) {
        String str = Integer.toString(num);
        int left = 0;
        int right = str.length() - 1;
        while (left <= right) {
            char leftChar = str.charAt(left);
            char rightChar = str.charAt(right);

            if (!((leftChar == '0' && rightChar == '0') ||
                    (leftChar == '1' && rightChar == '1') ||
                    (leftChar == '8' && rightChar == '8') ||
                    (leftChar == '6' && rightChar == '9') ||
                    (leftChar == '9' && rightChar == '6'))) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
