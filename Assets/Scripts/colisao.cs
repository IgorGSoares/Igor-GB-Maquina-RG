using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisao : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Nome: " + collision.gameObject.name);
        Debug.Log("Tag: " + collision.gameObject.tag);
        Debug.Log("Posição: " + collision.gameObject.transform.position);
        Debug.Log("EulerAngle: " + collision.gameObject.transform.eulerAngles);
        //Debug.Log(collision.gameObject.transform.localPosition);
        Debug.Log("LocalRotation: " + collision.gameObject.transform.localRotation);
        Debug.Log("LocalScale: " + collision.gameObject.transform.localScale);
        collision.gameObject.transform.GetComponent<test>().contact();
    }
}
