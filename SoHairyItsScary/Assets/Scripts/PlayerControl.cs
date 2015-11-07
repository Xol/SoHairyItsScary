using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	GameManager GM;

	void Awake () {
		GM = GameManager.Instance;
		GM.OnStateChange += HandleOnStateChange; // register eventhandler for 'OnStateChange' event
		
		Debug.Log("Current game state when Awakes: " + GM.gameState);

		Debug.Log("Trigger gamestate change...");
		GM.SetGameState(GameState.MAIN_MENU);
	}

	public void HandleOnStateChange ()
	{
		LoadLevel();
	}
	
	public void LoadLevel(){
		Debug.Log("Handling state change to: " + GM.gameState);
	}

    public GameObject player;
    public GameObject mesh;

    public static bool FloatsAreEqual(float first, float second) {
        float epsilon = 0.00001f;

        return System.Math.Abs(first - second) <= epsilon;
    }

    void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                iTween.MoveBy(player, new Vector3(1, 0, 0), 0.2f);
                mesh.transform.eulerAngles = new Vector3(0,90,0);
				GM.getCurrentGameArea().movePlayerX(1);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                iTween.MoveBy(player, new Vector3(-1, 0, 0), 0.2f);
                mesh.transform.eulerAngles = new Vector3(0, 270, 0);
				GM.getCurrentGameArea().movePlayerX(-1);
            }
        }

        if (Input.GetButtonDown("Vertical"))
        {
            if (Input.GetAxis("Vertical") > 0)
            {
                iTween.MoveBy(player, new Vector3(0, 0, 1), 0.2f);
                mesh.transform.eulerAngles = new Vector3(0, 0, 0);
				GM.getCurrentGameArea().movePlayerY(1);
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                iTween.MoveBy(player, new Vector3(0, 0, -1), 0.2f);
                mesh.transform.eulerAngles = new Vector3(0, 180, 0);
				GM.getCurrentGameArea().movePlayerY(-1);
            }

        }

    }

}
