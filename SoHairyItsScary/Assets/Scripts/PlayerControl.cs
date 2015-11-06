using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    //private Rigidbody rb;

    /*void Start()
    {
        rb = GetComponent<Rigidbody>();
    }*/

   /* void FixedUpdate()
    {
        float speed = 10f;

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        Debug.Log("Bewegung Hori: " + moveHorizontal.ToString());
        Debug.Log("Bewegung Verti: " + moveVertical.ToString());
        //rb.AddForce(movement * speed);
        rb.MovePosition();
    }*/

    void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            // moving to right
            if (Input.GetAxis("Horizontal") > 0)
            {
                iTween.MoveBy(this.gameObject, new Vector3(1, 0, 0), 0.2f);
            }
            // moving to left
            else if (Input.GetAxis("Horizontal") < 0)
            {
                iTween.MoveBy(this.gameObject, new Vector3(-1, 0, 0), 0.2f);
            }
        }

        if (Input.GetButtonDown("Vertical"))
        {
            // moving to up
            if (Input.GetAxis("Vertical") > 0)
            {
                iTween.MoveBy(this.gameObject, new Vector3(0, 0, 1), 0.2f);
            }
            // moving to down
            else if (Input.GetAxis("Vertical") < 0)
            {
                iTween.MoveBy(this.gameObject, new Vector3(0, 0, -1), 0.2f);
            }

        }

    }

}
