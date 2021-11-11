using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 last, first, current, addPos;

    public float v;
    
    void Start()
    {
        addPos = new Vector3(5, 0, 0);
        last = this.transform.position;
        current = this.transform.position;
        first = this.transform.position;
        calc();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void calc()
    {
        last = current;
        current += addPos;

        this.transform.position = current;

        v = (last.x - current.x) / Time.deltaTime;

        Debug.Log("DS: " + (last.x - current.x));
        Debug.Log("VM: " + v);
        Debug.Log("DT: " + Time.deltaTime);
    }
}
