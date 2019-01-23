using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHand : MonoBehaviour
{
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        pos.y = 1;
        transform.position = pos;
        GetComponent<Rigidbody>().velocity = new Vector3(100f, 1.0f, 10f).normalized * speed;
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
