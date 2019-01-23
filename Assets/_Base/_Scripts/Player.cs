using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public void Action()
    {
        int vmax = 4;
        int hmax = 4;

        Transform myTrans = GameObject.Find("MyCharacter").transform;
        Vector3 pos = myTrans.position;


        if (Input.GetKeyDown("w") && pos.x != 0)
        {
            pos.x -= 2.0f;
            if(GetComponent<CapsuleCollider>().enabled == false)
            {
                GetComponent<CapsuleCollider>().enabled = !GetComponent<CapsuleCollider>().enabled;
            }
        }

        if (Input.GetKeyDown("s") && pos.x < vmax)
        {
            pos.x += 2.0f;
            if (GetComponent<CapsuleCollider>().enabled == false)
            {
                GetComponent<CapsuleCollider>().enabled = !GetComponent<CapsuleCollider>().enabled;
            }
        }

        if (Input.GetKeyDown("a") && pos.z != 0)
        {
            pos.z -= 2.0f;
            if (GetComponent<CapsuleCollider>().enabled == false)
            {
                GetComponent<CapsuleCollider>().enabled = !GetComponent<CapsuleCollider>().enabled;
            }
        }

        if (Input.GetKeyDown("d") && pos.z < hmax)
        {
            pos.z += 2.0f;
            if (GetComponent<CapsuleCollider>().enabled == false)
            {
                GetComponent<CapsuleCollider>().enabled = !GetComponent<CapsuleCollider>().enabled;
            }
        }
        myTrans.position = pos;
    }

    public GameObject myexplosion;
    int mylife = 10;
    public Image hpGauge;
    public Image kaihiGauge;
    int kaihi = 0;
    int fullHp;
    int fullKaihi = 100;


    void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag == "medical")
        {
            print("medical");
            mylife += 3;
            if(mylife >= 10) { mylife = 10; }
            print(mylife);
            hpGauge.fillAmount = (float)mylife / fullHp;
        }


        if (coll.gameObject.tag == "enemybullet")
        {
            
            mylife -= 1;
            hpGauge.fillAmount = (float)mylife / fullHp;
            Instantiate(myexplosion, new Vector3(transform.position.x, transform.position.y - 2.0f, transform.position.z), Quaternion.identity);

            if (mylife == 0)
            {
                Destroy(this.gameObject);
                Destroy(coll.gameObject);
            }
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {
        fullHp = mylife;
    }

    

    void Kaihi()
    {
        kaihi += 1;
        kaihiGauge.fillAmount = (float)kaihi / fullKaihi;

        if(GetComponent<CapsuleCollider>().enabled == false && kaihi > 50)
        {
            GetComponent<CapsuleCollider>().enabled = !GetComponent<CapsuleCollider>().enabled;
        }

        if (Input.GetMouseButtonDown(1) && kaihi >= 100)
        {
            kaihi = 0;
            GetComponent<Animator>().SetTrigger("isGuard");
            if (GetComponent<CapsuleCollider>().enabled == true)
            {
                GetComponent<CapsuleCollider>().enabled = !GetComponent<CapsuleCollider>().enabled;
            }
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Action();
        Kaihi();
        
    }
}
