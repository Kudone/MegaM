using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsuJaku : MonoBehaviour
{
    public int speed = 10;

    void Start()
    {
        Vector3 pos = transform.position;
        pos.y = 1;
        transform.position = pos;
        GetComponent<Rigidbody>().velocity = transform.forward.normalized * speed;
        Destroy(this.gameObject, 0.57f);
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}

