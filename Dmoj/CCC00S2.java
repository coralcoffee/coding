package Dmoj;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class CCC00S2 {
    public static void main(String[] args) {
        Scanner inp = new Scanner("3\n10\n20\n30\n99\n1\n50\n88\n3\n88\n2\n77\n");

        List<Integer> streams = new ArrayList<>();
        int numberOfStreams = nextInt(inp);
        for (int i = 0; i < numberOfStreams; i++) {
            streams.add(nextInt(inp));
        }
        int num = nextInt(inp);
        while (num != 77) {
            if (num == 99) {
                num = nextInt(inp);
                int p = nextInt(inp);
                int s = streams.get(num - 1);
                streams.add(num - 1, (int) Math.round(s * p / 100.0));
                streams.set(num, s - streams.get(num - 1));
            } else if (num == 88) {
                num = nextInt(inp);
                streams.set(num - 1, streams.get(num - 1) + streams.get(num));
                streams.remove(num);
            }
            num = nextInt(inp);
        }
        for (Integer s : streams) {
            System.out.print(s + " ");
        }
    }

    private static int nextInt(Scanner inp) {
        return Integer.parseInt(inp.nextLine());
    }
}
