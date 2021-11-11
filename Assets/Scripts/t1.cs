using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    public float distanceBetweenObjects;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceBetweenObjects = Vector3.Distance(transform.position, obj.transform.position);
        Debug.Log("delta s: " + distanceBetweenObjects);
        Debug.DrawLine(transform.position, obj.transform.position, Color.black);
    }
}
