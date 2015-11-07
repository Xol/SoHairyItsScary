using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public GameObject player;
	public GameObject mesh;

	GameManager GM;

	void Awake () {
		GM = GameManager.Instance;
		GM.OnStateChange += HandleOnStateChange; // register eventhandler for 'OnStateChange' event
		
		Debug.Log("Current game state when Awakes: " + GM.gameState);

		Debug.Log("Trigger gamestate change...");
		GM.SetGameState(GameState.MAIN_MENU);

		positionPlayer();
	}

	public void HandleOnStateChange ()
	{
		LoadLevel();
	}
	
	public void LoadLevel(){
		Debug.Log("Handling state change to: " + GM.gameState);
	}
	
	public void positionPlayer() {
		Coord playerPosition = GM.getCurrentGameLevel().getPlayerPosition();

		player.transform.position = new Vector3 (playerPosition.x, 1.0f, playerPosition.z);
	}

    public static bool FloatsAreEqual(float first, float second) {
        float epsilon = 0.00001f;

        return System.Math.Abs(first - second) <= epsilon;
    }

    void Update()
    {
		GameLevel level = GM.getCurrentGameLevel ();

        if (Input.GetButtonDown("Horizontal"))
        {
            if (Input.GetAxis("Horizontal") > 0) // move right
            {
				mesh.transform.eulerAngles = new Vector3(0,90,0);
				if (level.playerCanMoveRight()) {
					iTween.MoveBy(player, new Vector3(1, 0, 0), 0.2f);                
					level.movePlayerRight();
				}
            }
            else if (Input.GetAxis("Horizontal") < 0) // move left
            {                
                mesh.transform.eulerAngles = new Vector3(0, 270, 0);
				if (level.playerCanMoveLeft()) {
					iTween.MoveBy(player, new Vector3(-1, 0, 0), 0.2f);
					level.movePlayerLeft();
				}
            }
        }

        if (Input.GetButtonDown("Vertical"))
        {
            if (Input.GetAxis("Vertical") > 0) // move top
            {
				mesh.transform.eulerAngles = new Vector3(0, 0, 0);
				if (level.playerCanMoveTop()) {
					iTween.MoveBy(player, new Vector3(0, 0, 1), 0.2f);                
					level.movePlayerTop();
				}
            }
            else if (Input.GetAxis("Vertical") < 0) // move bottom
            {
				mesh.transform.eulerAngles = new Vector3(0, 180, 0);
				if (level.playerCanMoveBottom()) {
					iTween.MoveBy(player, new Vector3(0, 0, -1), 0.2f);                
					level.movePlayerBottom();
				}
            }

        }

    }

}
