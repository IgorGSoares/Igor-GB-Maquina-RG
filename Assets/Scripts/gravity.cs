using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{

    //public Vector3 g = new Vector3(0, 0, 0);
    //void Start()
    //{
    //    //GetComponent<Rigidbody>().gravityScale = new Vector3(g.x, g.y, g.z);
    //    //Physics.gravity = new Vector3(g.x, g.y, g.z);
    //}


    //void Update()
    //{

    //}

    //private Rigidbody rb;
    //public float g = 0;  //gravity on the moon.
    //public int sentido = -1;
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //    if (g != 0)
    //        Physics.gravity = new Vector3(0, g * sentido, 0);
    //    else
    //        rb.useGravity = false;

    //    Debug.Log(Physics.gravity + ", " + this.gameObject.name);
    //}
    //void FixedUpdate()
    //{
    //    //rb.AddForce(Physics.gravity * rb.mass);
    //}



    private Rigidbody rb;
    public float v;
    public ConstantForce g;
    public int sentido = -1;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        g = gameObject.AddComponent<ConstantForce>();
        Physics.gravity = new Vector3(0, 0, 0);
        if (v == 0)
            rb.useGravity = false;
        else
            g.force = new Vector3(0.0f, v * sentido, 0.0f);

        //Debug.Log(Physics.gravity + ", " + this.gameObject.name);
    }
    void FixedUpdate()
    {
        //rb.AddForce(Physics.gravity * rb.mass);
    }
}
