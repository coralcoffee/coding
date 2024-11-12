package Dmoj;

import java.util.Scanner;

public class CCC00S1 {
    public static void main(String[] args) {
        Scanner inp = new Scanner("48\n3\n10\n4\n");
        int quarters = Integer.parseInt(inp.nextLine());
        int firstMachine = Integer.parseInt(inp.nextLine());
        int secondMachine = Integer.parseInt(inp.nextLine());
        int thirdMachine = Integer.parseInt(inp.nextLine());
        inp.close();
        int result = 0;
        while (quarters > 0) {
            quarters--;
            firstMachine++;
            result++;
            if (firstMachine == 35) {
                quarters += 30;
                firstMachine = 0;
            }
            if (quarters == 0) {
                break;
            }
            quarters--;
            secondMachine++;
            result++;
            if (secondMachine == 100) {
                quarters += 60;
                secondMachine = 0;
            }
            if (quarters == 0) {
                break;
            }
            quarters--;
            thirdMachine++;
            result++;
            if (thirdMachine == 10) {
                quarters += 9;
                thirdMachine = 0;
            }
        }
        System.out.printf("Martha plays %d times before going broke.", result);
    }
}
