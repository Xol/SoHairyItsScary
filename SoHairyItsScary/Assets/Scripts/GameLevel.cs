using UnityEngine;
using System.Collections;

// ------------------------------------------------------------------------------
// Represents "a piece of the world" in which the player can move and operate
// ------------------------------------------------------------------------------
public class GameLevel {
	public static int EDGE_SIZE_X = 32;
	public static int EDGE_SIZE_Z = 26;

	private GameField[,] fields = new GameField[EDGE_SIZE_X, EDGE_SIZE_Z];
	private Coord playerPosition = new Coord(1,1);

	public GameField getField(int xIndex, int zIndex) {
		return this.fields[xIndex, zIndex];
	}

	public void setField(int xIndex, int zIndex, GameField field) {
		this.fields[xIndex, zIndex] = field;
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
		this.playerPosition = new Coord(this.playerPosition.x, this.playerPosition.z + 1);
		Debug.Log("New player position: " + this.playerPosition);
	}
	
	public void movePlayerBottom() {
		this.playerPosition = new Coord(this.playerPosition.x, this.playerPosition.z - 1);
		Debug.Log("New player position: " + this.playerPosition);
	}

	public bool playerCanMoveLeft() {
		GameField leftField = getField(this.playerPosition.x - 1, this.playerPosition.z);

		return leftField.CanBeSteppedOn();
	}
	
	public bool playerCanMoveRight() {
		GameField rightField = getField(this.playerPosition.x + 1, this.playerPosition.z);

		return rightField.CanBeSteppedOn();
	}
	
	public bool playerCanMoveTop() {
		GameField topField = getField(this.playerPosition.x, this.playerPosition.z + 1);

		return topField.CanBeSteppedOn();
	}
	
	public bool playerCanMoveBottom() {
		GameField bottomField = getField(this.playerPosition.x, this.playerPosition.z - 1);

		return bottomField.CanBeSteppedOn();
	}
}