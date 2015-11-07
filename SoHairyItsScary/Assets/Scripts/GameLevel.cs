using UnityEngine;
using System.Collections;

// ------------------------------------------------------------------------------
// Represents "a piece of the world" in which the player can move and operate
// ------------------------------------------------------------------------------
public class GameLevel {
	public static int EDGE_SIZE = 15; // die Kantenlaenge des Spielfelds

	private GameField[,] fields = new GameField[EDGE_SIZE, EDGE_SIZE];
	private Coord playerPosition = new Coord(0,0);

	public GameField getField(int rowIndex, int colIndex) {
		return this.fields[rowIndex, colIndex];
	}

	public void setField(int rowIndex, int colIndex, GameField field) {
		this.fields[rowIndex, colIndex] = field;
	}

	public void setPlayerPosition(Coord newPosition) {
		this.playerPosition = newPosition;
	}

	public void movePlayerX(int offsetX) {
		int newValueX = this.playerPosition.x + offsetX;
		Coord newPosistion = new Coord(fixBoundary(newValueX), this.playerPosition.y);

		this.playerPosition = newPosistion;
		Debug.Log("New player position: " + this.playerPosition);
	}

	private int fixBoundary(int newValue) {
		if (newValue < 0) {
			return 0;
		} 
		if (newValue > EDGE_SIZE) {
			return EDGE_SIZE;
		}
		return newValue;
	}

	public void movePlayerY(int offsetY) {
		int newValueY = this.playerPosition.y + offsetY;
		Coord newPosistion = new Coord(this.playerPosition.x, fixBoundary(newValueY));
		
		this.playerPosition = newPosistion;
		Debug.Log("New player position: " + this.playerPosition);
	}
}