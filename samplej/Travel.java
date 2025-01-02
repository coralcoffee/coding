import java.util.Enumeration;

public class Travel {

    public static void main(String[] args) {

        Car c1 = new Car();
        Vehicle v1 = c1;
        System.out.println(c1);
        System.out.println(v1);
        System.out.println(((Car)v1).getNumDoors());
    }
}

class Vehicle {
}

class Car extends Vehicle {

    public int getNumDoors() {
        return 4;
    }
}