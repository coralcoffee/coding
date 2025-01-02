public class ChessPoint {
    public static int black = 0, white = 1;
    int x, y;
    int color;

    public ChessPoint(int i, int j, int c) {
        x = i;
        y = j;
        color = c;
    }

    public String toString() {
        String c = (color == black ? "black" : "white");
        return "[" + x + "," + y + "]:" + c;
    }
}
