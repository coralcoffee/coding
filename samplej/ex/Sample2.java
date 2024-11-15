package samplej.ex;
import java.security.Permission;

public class Sample2 extends Object {
    public static void main(String[] args) {

        Person per1 = new Teacher();
        per1.changeName("Will");
        display(per1);
    }

    static void display(Person person) {
        System.out.println(person.GetDislayInfo());
    }
}

class Student extends Person {
    public String GetDislayInfo() {
        return name + " is a student";
    }
}

class Teacher extends Person {
    @Override
    public String GetDislayInfo() {
        return name + " is a teacher";
    }
}

abstract class Person {
    public final static int MAX_AGE = 120;

    public Person() {
        super();
    }

    // public Person(String name, int age) {
    // this.name = name;
    // this.age = age;
    // }

    public void Init() {
    }

    public String name;
    public int age;

    public void changeName(String n) {
        name = n;
    }

    public abstract String GetDislayInfo();

    static String GetDislayInfo(String a, int b) {
        return String.format("Name: %s - Age: %s", a, b);
    }
}
