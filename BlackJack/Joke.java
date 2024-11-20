package BlackJack;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

public class Joke {
    private static Queue<String> jokes = new LinkedList<>();

    public static String nextJoke() {
        if (jokes.isEmpty()) {
            loadJokes();
        }
        return jokes.poll();
    }

    private static void loadJokes() {
        String currentPath = System.getProperty("user.dir");
        String filePath = currentPath + "\\BlackJack\\jokes.txt";
        List<String> lines = new ArrayList<>();
        try (BufferedReader br = new BufferedReader(new FileReader(filePath))) {
            String line;
            while ((line = br.readLine()) != null) {
                lines.add(line);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
        Collections.shuffle(lines);

        for (var l : lines) {
            jokes.add(l);
        }
    }
}
