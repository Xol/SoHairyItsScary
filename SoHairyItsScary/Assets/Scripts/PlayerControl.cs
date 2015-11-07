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
            // moving to right
            if (Input.GetAxis("Horizontal") > 0)
            {
                iTween.MoveBy(player, new Vector3(1, 0, 0), 0.2f);
                mesh.transform.eulerAngles = new Vector3(0,90,0);
                print("Winkel: " + mesh.transform.eulerAngles.y);
                /*if(!FloatsAreEqual(mesh.transform.eulerAngles.y, 90f)) {
                    mesh.transform.eulerAngles.Set(0, 90.0f, 0);
                    print("Winkel: " + mesh.transform.eulerAngles.y);
                }*/
                //iTween.MoveBy(this.gameObject, new Vector3(1, 0, 0), 0.2f);
            }
            // moving to left
            else if (Input.GetAxis("Horizontal") < 0)
            {
                iTween.MoveBy(player, new Vector3(-1, 0, 0), 0.2f);
                mesh.transform.eulerAngles = new Vector3(0, 270, 0);
                print("Winkel: " + mesh.transform.eulerAngles.y);
                /*if (!FloatsAreEqual(mesh.transform.eulerAngles.y, -90f))
                {
                    mesh.transform.eulerAngles.Set(0, -90.0f, 0);
                    print("Winkel: " + mesh.transform.eulerAngles.y);
                }*/
            }
        }

        if (Input.GetButtonDown("Vertical"))
        {
            // moving to up
            if (Input.GetAxis("Vertical") > 0)
            {
                iTween.MoveBy(player, new Vector3(0, 0, 1), 0.2f);
                mesh.transform.eulerAngles = new Vector3(0, 0, 0);
            }
            // moving to down
            else if (Input.GetAxis("Vertical") < 0)
            {
                iTween.MoveBy(player, new Vector3(0, 0, -1), 0.2f);
                mesh.transform.eulerAngles = new Vector3(0, 180, 0);
            }

        }

    }

}
