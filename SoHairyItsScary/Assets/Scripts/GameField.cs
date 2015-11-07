using UnityEngine;

// ------------------------------------------------------------------------------
// Represents a 1x1 tile in an GameArea
// ------------------------------------------------------------------------------
public abstract class GameField
{
	private bool canBeSteppedOn;
	
	public GameField() {
		this.canBeSteppedOn = true;
	}

	public GameField(bool canBeSteppedOn) {
		this.canBeSteppedOn = canBeSteppedOn;
	}

	public bool CanBeSteppedOn() {
		return this.canBeSteppedOn;
	}
}
