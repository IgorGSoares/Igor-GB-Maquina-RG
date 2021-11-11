using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impulse : MonoBehaviour
{
    Rigidbody gameObjectsRigidBody;
    public Vector3 aply = new Vector3(0, 0, 0);
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObjectsRigidBody = this.gameObject.GetComponent<Rigidbody>();
            gameObjectsRigidBody.AddForce(new Vector3(aply.x, aply.y, aply.z), ForceMode.Impulse);
        }
    }
}
