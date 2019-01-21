using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int speed = 10;
    
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward.normalized * speed;
        Destroy(this.gameObject, 0.57f);
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "enemy")
        {
                Destroy(this.gameObject);
        }
    }
}
