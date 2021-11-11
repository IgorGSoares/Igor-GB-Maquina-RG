using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prefab;
    public GameObject origin;
    public float intensity;
    public float countdown = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shoot()
    {
        StartCoroutine(bullet());
    }

    IEnumerator bullet()
    {
        Debug.Log("entrou metodo");
        GameObject clone;
        yield return new WaitForSeconds(5);
        Debug.Log("fim tempo");
        clone = Instantiate(prefab, origin.transform.position, transform.rotation);
        clone.GetComponent<Rigidbody>().AddForce(transform.forward * intensity, ForceMode.Impulse);
    }

    //void OnDrawGizmos()
    //{
    //    Vector3 from;
    //    Vector3 to;

    //    from = prefab.transform.position;
    //    to = new Vector3(prefab.transform.position.x * 10, prefab.transform.position.y * 10, 0);

    //    Gizmos.color = Color.red;
    //    Gizmos.DrawLine(from, to);
    //}
}
