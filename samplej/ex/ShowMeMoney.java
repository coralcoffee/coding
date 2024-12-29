package samplej.ex;

public class ShowMeMoney {
    public static void main(String[] args) {
        Vehicle v = new Truck();

        v.start();
        v.accelerate(60);
        System.out.println(v.speed);
    }
}

interface InnerShowMeMoney {
    abstract public void accelerate(int n);
}

abstract class Vehicle {
    public int speed;

    public void start() {
        accelerate(50);
        System.out.println("Starting");
    }

    abstract public void accelerate(int n);
}

class Car extends Vehicle {
    public String brand;

    @Override
    public void accelerate(int n) {
        speed += n;
    }
}

class Truck extends Vehicle {
    public void accelerate(int n) {
        if (speed + n >= 100) {
            speed = 100;
        } else {
            speed += n;
        }
    }
}
