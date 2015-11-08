using UnityEngine;
using System.Collections;

public class Chest : MonoBehaviour {
	public enum ChestState {
		open,
		closed,
		animationInProgress
	}

	public ChestState state;

	// Use this for initialization
	void Start () {
		this.state = ChestState.closed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnMouseEnter() { // event-callback triggered by collider
		Debug.Log("Mouse over.");
	}

	public void OnMouseExit() { // event-callback triggered by collider
		Debug.Log("Mouse out.");
	}
	
	public void OnMouseUp() { // event-callback triggered by collider
		Debug.Log("Mouse button relieved.");
		if (state == ChestState.closed) {
			Open();
		} else if (state == ChestState.open) {
			Close();
		}
	}

	private void Open() {
		state = ChestState.animationInProgress;
		GetComponent<Animation>().Play("ChestAnim");
		GetComponent<AudioSource>().Play();
		state = ChestState.open;
	}
	
	private void Close() {
		
	}
}
