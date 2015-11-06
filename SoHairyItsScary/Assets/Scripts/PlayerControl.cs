using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float speed = 10f;

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        Debug.Log("Bewegung Hori: " + moveHorizontal.ToString());
        Debug.Log("Bewegung Verti: " + moveVertical.ToString());
        rb.AddForce(movement * speed);
    }

}
