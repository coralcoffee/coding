import java.util.Scanner;

public class SumDigits {

    public static void main(String[] args) {
        Scanner inp = new Scanner("12a3b4c56");
        System.out.println(getSumDigits(inp.nextLine()));
        inp.close();
    }

    static int getSumDigits(String str) {
        int result = 0;
        for (int i = 0; i < str.length(); i++) {
            if (str.charAt(i) >= '0' && str.charAt(i) <= '9') {
                result += str.charAt(i) - '0';
            }
        }
        return result;
    }
}
