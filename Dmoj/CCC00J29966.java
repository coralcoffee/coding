package Dmoj;

import java.util.Scanner;

public class CCC00J29966 {
    public static void main(String[] args) {
        Scanner inp = new Scanner(System.in);
        int start = Integer.parseInt(inp.nextLine());
        int end = Integer.parseInt(inp.nextLine());
        inp.close();
        int result = 0;
        for (int i = start; i <= end; i++) {
            String str = Integer.toString(i);
            boolean isSame = false;
            for (int j = 0; j < (str.length() + 1) / 2; j++) {
                char c = str.charAt(j);
                switch (c) {
                    case '0':
                    case '1':
                    case '8':
                        isSame = c == str.charAt(str.length() - j - 1);
                        break;
                    case '6':
                        isSame = '9' == str.charAt(str.length() - j - 1);
                        break;
                    case '9':
                        isSame = '6' == str.charAt(str.length() - j - 1);
                        break;
                    default:
                        isSame = false;
                        break;
                }
                if (!isSame)
                    break;
            }
            if (isSame) {
                result++;
            }
            isSame = false;
        }
        System.out.println(result);
    }
}
