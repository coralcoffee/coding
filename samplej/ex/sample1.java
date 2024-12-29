package samplej.ex;
import java.util.*;

public class sample1 {
    public static void main(String[] args) {
        sample1 sample = new sample1();
        // System.out.println(Integer.MAX_VALUE);
        // System.out.println(Integer.MIN_VALUE);
        System.out.println(sample.romanToInt("LVIII"));
    }

    public int romanToInt(String s) {
        HashMap<Character, Integer> symbolValues = new HashMap<>();
        symbolValues.put('I', 1);
        symbolValues.put('V', 5);
        symbolValues.put('X', 10);
        symbolValues.put('L', 50);
        symbolValues.put('C', 100);
        symbolValues.put('D', 500);
        symbolValues.put('M', 1000);
        int result = 0;
        for (int i = 0; i < s.length(); i++) {
            int curValue = symbolValues.get(s.charAt(i));
            int nextValue = i < s.length() - 1 ? symbolValues.get(s.charAt(i + 1)) : 0;

            result += curValue < nextValue ? curValue * -1 : curValue;
        }
        return result;
    }

    public boolean isPalindrome(int x) {
        if (x < 0)
            return false;
        return isPalindrome(x / 10, x % 10, x);
    }

    boolean isPalindrome(int num1, int digit, int num2) {
        if (num1 == digit) {
            return true;
        } else if (num1 == 0) {
            return false;
        }
        return isPalindrome(num1 / 10, digit, num2)
                && isPalindrome(num2);
    }

    public int myAtoi(String s) {
        int index = 0;
        int result = 0;
        int sign = 1;

        while (index < s.length() && s.charAt(index) == ' ') {
            index++;
        }

        if (index < s.length() && (s.charAt(index) == '-' || s.charAt(index) == '+')) {
            if (s.charAt(index) == '-') {
                sign = -1;
            }
            index++;
        }

        while (index < s.length() && s.charAt(index) >= '0' && s.charAt(index) <= '9') {
            int digit = s.charAt(index) - '0';
            if (result > (Integer.MAX_VALUE - digit) / 10) {
                return sign == 1 ? Integer.MAX_VALUE : Integer.MIN_VALUE;
            }

            result = result * 10 + digit;

            System.out.println(result);
            index++;
        }
        return result * sign;
    }

    public int reverse(int x) {
        int result = 0;
        Integer num = x;
        while (num != 0) {
            if (result > Integer.MAX_VALUE / 10
                    || result < Integer.MIN_VALUE / 10) {
                return 0;
            }
            result = result * 10 + (num % 10);
            num = num / 10;
        }
        return result;
    }

    static void run(int speed) {
        Car car1 = new Car();
        car1.Speed = speed;
        car1.Run();

        speed = 100;
    }

    static void run(Car car) { // car = car1, = 50
        car.Run();
        car.Speed = 100;
    }

    private static int LCM(int a, int b) {
        return a * b / GCD(a, b);
    }

    private static int GCD(int a, int b) {
        if (a < b) {
            int t = a;
            a = b;
            b = t;
        }
        int r = a % b;
        if (r == 0) {
            return b;
        } else {
            return GCD(b, r);
        }
    }
}

class Car {
    public int Speed = 0;

    public void Run() {
        System.out.println(Speed); // 50
    }
}