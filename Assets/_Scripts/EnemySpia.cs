using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpia : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        pos.y = 7;
        transform.position = pos;
        Destroy(this.gameObject, 1.2f);
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
