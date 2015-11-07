using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

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
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                iTween.MoveBy(player, new Vector3(-1, 0, 0), 0.2f);
                mesh.transform.eulerAngles = new Vector3(0, 270, 0);
            }
        }

        if (Input.GetButtonDown("Vertical"))
        {
            if (Input.GetAxis("Vertical") > 0)
            {
                iTween.MoveBy(player, new Vector3(0, 0, 1), 0.2f);
                mesh.transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                iTween.MoveBy(player, new Vector3(0, 0, -1), 0.2f);
                mesh.transform.eulerAngles = new Vector3(0, 180, 0);
            }

        }

    }

}
