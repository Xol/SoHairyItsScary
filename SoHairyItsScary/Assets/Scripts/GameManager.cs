using UnityEngine;
using System.Collections;

public enum GameState { INTRO, MAIN_MENU, PAUSED, GAME, CREDITS, HELP }

public delegate void OnStateChangeHandler();

public class GameManager: Object {
	protected GameManager() { } // prevent direct instantiation

	private static GameManager instance = null;

	public event OnStateChangeHandler OnStateChange; // declare callback method that will be triggered on game state changes

	public  GameState gameState { get; private set; }
	
	public static GameManager Instance{ 
		get {
			if (GameManager.instance == null){
				GameManager.instance = new GameManager();
				DontDestroyOnLoad(GameManager.instance); // make sure instance doesnt get destoyed between scenes
			}
			return GameManager.instance;
		}		
	}
	
	public void SetGameState(GameState state){
		this.gameState = state;
		OnStateChange();
	}
	
	public void OnApplicationQuit(){
		GameManager.instance = null;
	}
	
}
