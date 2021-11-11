using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleforce : MonoBehaviour
{
    Rigidbody gameObjectsRigidBody;
    void Start()
    {
        gameObjectsRigidBody = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameObjectsRigidBody.AddForce(transform.forward * 1000f, ForceMode.Acceleration);
        gameObjectsRigidBody.useGravity = true;
    }
}
