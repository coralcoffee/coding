package Dmoj;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Scanner;

// CCC '00 S3 - Surfing
public class CCC00S3 {
    public static void main(String[] args) {
        String input = """
                3
                http://ccc.uwaterloo.ca
                <HTML> <TITLE>This is the CCC page</TITLE>
                Hello there boys
                and girls.  <B>Let's</B> try <A HREF="http://abc.def/ghi"> a
                little
                problem </A>
                </HTML>
                http://abc.def/ghi
                <HTML> Now is the <TITLE>time</TITLE> for all good people to program.
                <A HREF="http://www.www.www.com">hello</A><A HREF="http://xxx">bye</A><A HREF="">bye</A>
                </HTML>
                http://www.www.www.com
                <HTML>
                <TITLE>Weird and Wonderful World</TITLE>
                </HTML>
                http://ccc.uwaterloo.ca
                http://www.www.www.com
                http://www.www.www.com
                http://ccc.uwaterloo.ca
                The End
                                """;
        Scanner inp = new Scanner(input);
        String line = inp.nextLine();
        int numOfPages = Integer.parseInt(line);
        HashMap<String, WebPage> webPages = new HashMap<>();
        for (int i = 0; i < numOfPages; i++) {
            String url = inp.nextLine();
            WebPage webpage = new WebPage(url);
            webPages.put(url, webpage);
            line = inp.nextLine();
            while (!line.equals("</HTML>")) {
                int index = line.indexOf("HREF=");
                while (index >= 0) {
                    String link = line.substring(index + 6, line.indexOf("\">", index));
                    if (!link.trim().isEmpty()) {
                        System.out.printf("Link from %s to %s", url, link);
                        System.out.println();
                        webpage.addLink(link);
                    }
                    index = line.indexOf("HREF=", index + 1);
                }
                line = inp.nextLine();
            }
        }
        line = inp.nextLine();
        while (!line.equals("The End")) {
            String link = inp.nextLine();
            if (canSurf(webPages, line, link, new HashSet<>())) {
                System.out.printf("Can surf from %s to %s.", line, link);
            } else {
                System.out.printf("Can't surf from %s to %s.", line, link);
            }
            System.out.println();
            line = inp.nextLine();
        }
        inp.close();
    }

    private static boolean canSurf(HashMap<String, WebPage> dict, String url, String link, HashSet<String> visited) {

        if (!dict.containsKey(url) || visited.contains(url)) {
            return false;
        }
        WebPage webpage = dict.get(url);
        if (webpage.links.contains(link)) {
            return true;
        }
        visited.add(url);
        for (String l : webpage.links) {
            if (canSurf(dict, l, link, visited)) {
                return true;
            }
        }
        return false;
    }
}

class WebPage {
    public String url;

    public ArrayList<String> links;

    public WebPage(String url) {
        this.url = url;
        this.links = new ArrayList<>();
    }

    public void addLink(String link) {
        links.add(link);
    }
}