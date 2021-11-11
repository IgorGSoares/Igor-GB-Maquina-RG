using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerarotate : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.RotateAround(transform.position, Vector3.up, 2);
        else if (Input.GetKey(KeyCode.D))
            transform.RotateAround(transform.position, -Vector3.up, 2);
        if (Input.GetKey(KeyCode.W))
            transform.RotateAround(transform.position, Vector3.right, 2);
        else if (Input.GetKey(KeyCode.S))
            transform.RotateAround(transform.position, -Vector3.right, 2);
    }
}
