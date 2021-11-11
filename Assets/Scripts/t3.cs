using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t3 : MonoBehaviour
{
    public float speed = 2f;
    public float countdown = 5.0f;


    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0.0f)
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        else if (countdown >= 0.0f)
            Debug.Log("Timer: " + countdown);
    }
}
