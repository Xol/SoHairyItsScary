using UnityEngine;
using System.Collections;

public class Instantiation : MonoBehaviour {
    public Transform CubeForFloor;
    // Use this for initialization
    void Start()
    {
        Instantiate(CubeForFloor, new Vector3(0, -0.5f, 0), Quaternion.identity);
        for (int x = -2; x < 6; x++)
        {
            for (int z = -2; z < 6; z++)
            {
                Instantiate(CubeForFloor, new Vector3(x, -0.5f, z), Quaternion.identity);
            }
        }
    }
}
