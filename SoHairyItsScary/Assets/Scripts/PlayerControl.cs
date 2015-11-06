using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * 1000;
        float moveVertical = Input.GetAxis("Vertical") * 1000;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        Debug.Log("Bewegung Hori: " + moveHorizontal.ToString());
        Debug.Log("Bewegung Verti: " + moveVertical.ToString());
        rb.AddForce(movement * speed);
    }

}
