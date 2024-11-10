package Dmoj;

import java.util.Scanner;

public class CCC00J1 {
    public static void main(String[] args) {
        Scanner inp = new Scanner("1 28");
        int dayOfWeek = inp.nextInt();
        int daysOfMonth = inp.nextInt();
        inp.close();
        String str = "Sun Mon Tue Wed Thr Fri Sat\n";
        str += " ".repeat((dayOfWeek - 1) * 4);
        for (int i = 1; i <= daysOfMonth; i++) {
            str += String.format("%3d", i);
            if ((i + dayOfWeek - 1) % 7 == 0 || i == daysOfMonth) {
                str += "\n";
            } else {
                str = str + " ";
            }
        }
        System.out.print(str);
    }
}
