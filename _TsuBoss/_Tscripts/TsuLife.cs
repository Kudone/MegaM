using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TsuLife : MonoBehaviour
{


    public GameObject explosion;
    int life = 100;
    public Image ehpGauge;
    int efullHp;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "bullet")
        {
            print(life);
            life -= 1;
            ehpGauge.fillAmount = (float)life / efullHp;
            Instantiate(explosion, new Vector3(transform.position.x, transform.position.y - .0f, transform.position.z), Quaternion.identity);

            if (life == 0)
            {
                Destroy(this.gameObject);
                Destroy(coll.gameObject);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        efullHp = life;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
