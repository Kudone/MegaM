using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyLife : MonoBehaviour
{


    public GameObject explosion;
    int life = 100;
    public Image ehpGauge;
    int efullHp;
    public GameObject clear;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "bullet")
        {
            print(life);
            life -= 1;
            ehpGauge.fillAmount = (float)life / efullHp;
            Instantiate(explosion, new Vector3(transform.position.x, transform.position.y - 2.0f, transform.position.z), Quaternion.identity);

            if (life == 0)
            {
                Instantiate(clear, transform.position, Quaternion.identity);
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
