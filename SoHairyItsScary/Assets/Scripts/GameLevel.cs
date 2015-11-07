using UnityEngine;
using System.Collections;

// ------------------------------------------------------------------------------
// Represents "a piece of the world" in which the player can move and operate
// ------------------------------------------------------------------------------
public class GameLevel {
	public static int EDGE_SIZE_X = 32; // die Kantenlaenge des Spielfelds in X-Richtung
	public static int EDGE_SIZE_Z = 26; // die Kantenlaenge des Spielfelds in Y-Richtung

	private GameField[,] fields = new GameField[EDGE_SIZE_X, EDGE_SIZE_Z];
	private Coord playerPosition = new Coord(1,1);

	public GameField getField(int rowIndex, int colIndex) {
		return this.fields[rowIndex, colIndex];
	}

	public void setField(int rowIndex, int colIndex, GameField field) {
		this.fields[rowIndex, colIndex] = field;
	}

	public Coord getPlayerPosition() {
		return this.playerPosition;
	}

	public void setPlayerPosition(Coord newPosition) {
		this.playerPosition = newPosition;
	}

	public void movePlayerLeft() {
		this.playerPosition = new Coord(this.playerPosition.x - 1, this.playerPosition.z);
		Debug.Log("New player position: " + this.playerPosition);
	}
	
	public void movePlayerRight() {
		this.playerPosition = new Coord(this.playerPosition.x + 1, this.playerPosition.z);
		Debug.Log("New player position: " + this.playerPosition);
	}

	public void movePlayerTop() {
		this.playerPosition = new Coord(this.playerPosition.x, this.playerPosition.z - 1);
		Debug.Log("New player position: " + this.playerPosition);
	}
	
	public void movePlayerBottom() {
		this.playerPosition = new Coord(this.playerPosition.x, this.playerPosition.z + 1);
		Debug.Log("New player position: " + this.playerPosition);
	}
/*
	public void movePlayerX(int offsetX) {
		int newValueX = this.playerPosition.x + offsetX;
		Coord newPosistion = new Coord(newValueX, this.playerPosition.z);

		this.playerPosition = newPosistion;
		Debug.Log("New player position: " + this.playerPosition);
	}

	public void movePlayerZ(int offsetZ) {
		int newValueZ = this.playerPosition.z + offsetZ;
		Coord newPosistion = new Coord(this.playerPosition.x, newValueZ);
		
		this.playerPosition = newPosistion;
		Debug.Log("New player position: " + this.playerPosition);
	}
*/

	public bool playerCanMoveLeft() {
		GameField leftField = getField(this.playerPosition.x - 1, this.playerPosition.z);

		return leftField.CanBeSteppedOn();
	}
	
	public bool playerCanMoveRight() {
		GameField rightField = getField(this.playerPosition.x + 1, this.playerPosition.z);

		return rightField.CanBeSteppedOn();
	}
	
	public bool playerCanMoveTop() {
		GameField topField = getField(this.playerPosition.x, this.playerPosition.z - 1);

		return topField.CanBeSteppedOn();
	}
	
	public bool playerCanMoveBottom() {
		GameField bottomField = getField(this.playerPosition.x, this.playerPosition.z + 1);

		return bottomField.CanBeSteppedOn();
	}
}