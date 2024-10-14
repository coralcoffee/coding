import java.util.Scanner;

public class sample1 {
    public static void main(String[] args) {

        Scanner inp = new Scanner("50");
        int s = inp.nextInt(); // s = 50 
        run(s);
        System.out.println(s);

        System.out.println("-------------------");

        Car car1 = new Car(); //Speed = 0
        car1.Speed = s; // car1 = 50
        run(car1);
        System.out.println(car1.Speed);
        inp.close();
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