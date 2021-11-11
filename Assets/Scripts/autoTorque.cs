using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoTorque : MonoBehaviour
{
    public float speed = 50f;
    Rigidbody gameObjectsRigidBody;
    void Start()
    {
        gameObjectsRigidBody = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObjectsRigidBody = this.gameObject.GetComponent<Rigidbody>();
        gameObjectsRigidBody.AddTorque(transform.up * speed * Time.deltaTime, ForceMode.VelocityChange);
    }

    private void OnMouseDown()
    {
        gameObjectsRigidBody.AddForce(transform.forward * 250, ForceMode.Acceleration);
        gameObjectsRigidBody.useGravity = true;
    }
}
