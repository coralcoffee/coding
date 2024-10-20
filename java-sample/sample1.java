import java.util.Scanner;

public class sample1 {
    public static void main(String[] args) {
        sample1 sample = new sample1();
        System.out.println(Integer.MAX_VALUE);
        System.out.println(Integer.MIN_VALUE);
        System.out.println(sample.reverse(-1534236469));
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