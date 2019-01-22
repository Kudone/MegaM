using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    public GameObject bullet;

    void Shot()
    {

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Animator>().SetTrigger("isFire");
            // 弾をプレイヤーと同じ位置/角度で作成
            Instantiate(bullet, transform.position, transform.rotation);
            // 0.05秒待つ
            if (GetComponent<CapsuleCollider>().enabled == false)
            {
                GetComponent<CapsuleCollider>().enabled = !GetComponent<CapsuleCollider>().enabled;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shot();
    }
}
