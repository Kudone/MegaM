using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject explosion;
    int life = 100;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "bullet")
        {
            print(life);
            life -= 1;
            Instantiate(explosion, new Vector3(transform.position.x, transform.position.y - 2.0f, transform.position.z), Quaternion.identity);
            
            if (life == 0)
            {
                Destroy(this.gameObject);
                Destroy(coll.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
