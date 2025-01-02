import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.ArrayList;

public class ChessBoard extends JPanel {
    public static final int DefaultGridLen = 22, DefaultGridNum = 19;

    private ArrayList<ChessPoint> chessman;
    private int alreadyNum;
    private int currentTurn;
    private int gridNum, gridLen;
    private int chessmanLength;
    private ChessPoint[][] map;
    private Image offScreen;
    private Graphics offGrid;
    private int size = 0;
    private int top = 13, left = 13;
    private Point mouseClick;
    private ControlPanel controlPanel;

    public ChessBoard() {
        gridNum = DefaultGridNum;
        gridLen = DefaultGridLen;
        chessmanLength = gridLen * 9 / 10;
        size = 2 * left + gridNum * gridLen;
        addMouseListener(new PlayChess());
        addMouseMotionListener(new mousePosition());
        setLayout(new BorderLayout());
        controlPanel = new ControlPanel();
        setSize(getWidth(), size);
        add(controlPanel, "West");
        startGame();
    }

    @Override
    public void addNotify() {
        super.addNotify();
        offScreen = createImage(size, size);
        offGrid = offScreen.getGraphics();
    }

    public void startGame() {
        chessman = new ArrayList<ChessPoint>();
        alreadyNum = 0;
        map = new ChessPoint[gridNum + 1][gridNum + 1];
        currentTurn = ChessPoint.black;
        controlPanel.setLabel();
        repaint();
    }

    private class mousePosition extends MouseMotionAdapter {

        public void mouseMoved(MouseEvent evt) {
            int xoff = left / 2;
            int yoff = top / 2;
            int x = (evt.getX() - xoff - 3 * DefaultGridLen) / gridLen;
            int y = (evt.getY() - yoff) / gridLen;

            if (x < 0 || x > gridNum || y < 0 || y > gridNum) {
                return;
            }
            if (map[x][y] != null) {
                return;
            }

            mouseClick = new Point(x, y);
            repaint();
        }
    }

    public int getWidth() {
        return size + controlPanel.getWidth() + 35;
    }

    public int getHeight() {
        return size;
    }

    @Override
    public void update(Graphics g) {
        paint(g);
    }

    public void paint(Graphics g) {
        offGrid.setColor(new Color(180, 150, 100));
        offGrid.fillRect(0, 0, size, size);

        offGrid.setColor(Color.black);
        for (int i = 0; i < gridNum + 1; i++) {
            int x1 = left + i * gridLen;
            int x2 = x1;
            int y1 = top;
            int y2 = top + gridNum * gridLen;
            offGrid.drawLine(x1, y1, x2, y2);

            x1 = left;
            x2 = left + gridNum * gridLen;
            y1 = top + i * gridLen;
            y2 = y1;
            offGrid.drawLine(x1, y1, x2, y2);
        }
        for (int i = 0; i < gridNum + 1; i++) {
            for (int j = 0; j < gridNum + 1; j++) {
                if (map[i][j] == null)
                    continue;
                offGrid.setColor(map[i][j].color == ChessPoint.black ? Color.black : Color.white);
                offGrid.fillOval(left + i * gridLen - chessmanLength / 2,
                        top + j * gridLen - chessmanLength / 2, chessmanLength, chessmanLength);
            }
        }

        if (mouseClick != null) {
            offGrid.setColor(currentTurn == ChessPoint.black ? Color.gray : new Color(200, 200, 250));
            offGrid.fillOval(left + mouseClick.x * gridLen - chessmanLength / 2,
                    top + mouseClick.y * gridLen - chessmanLength / 2, chessmanLength, chessmanLength);
        }
        g.drawImage(offScreen, 80, 0, this);
    }

    class ControlPanel extends Panel {
        protected Label lblTurn = new Label("", Label.CENTER);
        protected Label lblNum = new Label("", Label.CENTER);
        protected Label lblMsg = new Label("", Label.CENTER);
        protected Button back = new Button("Undo");
        protected Button start = new Button("Restart");

        public int getWidth() {
            return 45;
        }

        public int getHeight() {
            return size;
        }

        public ControlPanel() {
            setSize(this.getWidth(), this.getHeight());
            setLayout(new GridLayout(12, 1, 0, 10));
            add(lblTurn);
            add(lblNum);
            add(start);
            add(lblMsg);
            add(back);
            setBackground(new Color(120, 120, 200));
            start.addActionListener(new BackChess());
        }

        public Insets getInsets() {
            return new Insets(5, 5, 5, 5);
        }

        private class BackChess implements ActionListener {
            public void actionPerformed(ActionEvent evt) {
                if (evt.getSource() == back) {
                    // ChessBoard.this.back();
                } else if (evt.getSource() == start)
                    ChessBoard.this.startGame();
            }
        }

        public void setLabel() {
            lblTurn.setText(ChessBoard.this.currentTurn == ChessPoint.black ? "White" : "Black");
            lblTurn.setForeground(ChessBoard.this.currentTurn == ChessPoint.black ? Color.black : Color.white);
            lblNum.setText("The " + (ChessBoard.this.alreadyNum + 1) + " Move");
            lblNum.setForeground(ChessBoard.this.currentTurn == ChessPoint.black ? Color.black : Color.white);
            lblMsg.setText("");
        }

        public void setMsg(String msg) {
            lblMsg.setText(msg);
        }
    }

    class PlayChess extends MouseAdapter {
        public void mousePressed(MouseEvent evt) {
            int xoff = left / 2;
            int yoff = top / 2;

            int x = (evt.getX() - xoff - 3 * DefaultGridLen) / gridLen;
            int y = (evt.getY() - yoff) / gridLen;
            if (x < 0 || x > gridNum || y < 0 || y > gridNum)
                return;

            if (map[x][y] != null)
                return;

            if (alreadyNum < chessman.size()) {
                int size = chessman.size();
                for (int i = size - 1; i >= alreadyNum; i--)
                    chessman.remove(i);
            }

            ChessPoint goPiece = new ChessPoint(x, y, currentTurn);

            map[x][y] = goPiece;
            chessman.add(goPiece);
            alreadyNum++;
            if (currentTurn == ChessPoint.black) {
                currentTurn = ChessPoint.white;
            } else {
                currentTurn = ChessPoint.black;
            }

            mouseClick = null;
            controlPanel.setLabel();
        }

        public void mouseExited(MouseEvent evt) {
            mouseClick = null;
            repaint();
        }
    }

}
