import javax.swing.*;
import java.awt.*;

public class ChessGame extends JFrame {
    private final static int DEFAULT_WIDTH = 550, DEFAULT_HEIGHT = 490;
    ChessBoard chessBoard = new ChessBoard();

    public ChessGame() {

        this.setTitle("Simple GO");
        this.setLayout(new BorderLayout());
        this.setSize(chessBoard.getSize());
        this.add(chessBoard, "Center");
        this.setResizable(false);
        this.setLayout(new BorderLayout());
        this.setSize(DEFAULT_WIDTH, DEFAULT_HEIGHT);

        setScreenCenter();
        this.setVisible(true);
    }

    private void setScreenCenter() {
        Toolkit toolkit = Toolkit.getDefaultToolkit();
        Dimension screenSize = toolkit.getScreenSize();
        int screenWidth = screenSize.width;
        int screenHeight = screenSize.height;
        this.setLocation((screenWidth - DEFAULT_WIDTH) / 2, (screenHeight - DEFAULT_HEIGHT) / 2);
    }

    public int getWidth() {
        return chessBoard.getWidth();
    }

    public int getHeight() {
        return chessBoard.getHeight();
    }
}
