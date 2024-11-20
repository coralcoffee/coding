package samplej.BlackJack;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

public class Joke {
    private Queue<String> jokes;

    public Joke() {
        jokes = new LinkedList<>();
    }

    public String nextJoke() {
        if (this.jokes.isEmpty()) {
            loadJokes();
        }
        return jokes.poll();
    }

    private void loadJokes() {
        String currentPath = System.getProperty("user.dir");
        String filePath = currentPath + "\\samplej\\BlackJack\\jokes.txt";
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
