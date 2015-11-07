using System.Collections;

// ------------------------------------------------------------------------------
// Represents "a piece of the world" in which the player can move and operate
// ------------------------------------------------------------------------------
public class GameArea {
	public static int EDGE_SIZE = 15; // die Kantenlaenge des Spielfelds
	private GameField[,] fields = new GameField[EDGE_SIZE,EDGE_SIZE];

	public void setField(int rowIndex, int colIndex, GameField field) {
		this.fields[rowIndex, colIndex] = field;
	}
}
