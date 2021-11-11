using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathfollower : MonoBehaviour
{
    public float speed = 1f;
    public Transform pathParent;
    Transform targetpoint;
    int index;

    void OnDrawGizmos()
    {
        Vector3 from;
        Vector3 to;

        for(int i = 0; i < pathParent.childCount; i++)
        {
            from = pathParent.GetChild(i).position;
            to = pathParent.GetChild((i + 1) % pathParent.childCount).position;

            Gizmos.color = Color.red;
            Gizmos.DrawLine(from, to);
        }
    }

    void Start()
    {
        index = 0;
        targetpoint = pathParent.GetChild(index);
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            speed += 0.5f;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            speed -= 0.5f;
        }

        transform.position = Vector3.MoveTowards(transform.position, targetpoint.position, speed * Time.deltaTime);
        if(Vector3.Distance(transform.position, targetpoint.position) < 0.1f)
        {
            index++;
            index %= pathParent.childCount;
            targetpoint = pathParent.GetChild(index);
        }
    }
}
