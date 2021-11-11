using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bt_colision_1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject gun;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        gun.transform.GetComponent<gun>().shoot();
    }
}
