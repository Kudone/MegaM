using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsuFinal : MonoBehaviour
{
    public int speed = 10;
    public GameObject final;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        Vector3 force = new Vector3(0f, 50.0f, 0f);  // 力を設定
        rb.AddForce(force, ForceMode.Impulse);
        Destroy(this.gameObject, 2f);
        Instantiate(final, new Vector3(2, 40 , 2), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
