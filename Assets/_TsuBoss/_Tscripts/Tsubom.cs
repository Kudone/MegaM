using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tsubom : MonoBehaviour
{
    public int speed = 1;

    void Start()
    {
        Vector3 pos = transform.position;
        pos.y += 1;
        transform.position = pos;
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        Vector3 force = new Vector3(0f, 8.0f, -3.25f);  // 力を設定
        rb.AddForce(force, ForceMode.Impulse);
        Destroy(this.gameObject, 3f);
    }

    public GameObject explo;
    public GameObject explo_particle;

    

    void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag == "stage")
        {
            Instantiate(explo_particle, this.transform.position, Quaternion.Euler(0, 0, 0));
            Instantiate(explo_particle, this.transform.position, Quaternion.Euler(0, 90, 0));
            Instantiate(explo_particle, this.transform.position, Quaternion.Euler(0, 180, 0));
            Instantiate(explo_particle, this.transform.position, Quaternion.Euler(0, 270, 0));

            Instantiate(explo, this.transform.position, Quaternion.Euler(0, 0, 0));
            Instantiate(explo, this.transform.position + new Vector3(2, 0, 0), Quaternion.Euler(0, 0, 0));
            Instantiate(explo, this.transform.position + new Vector3(-2, 0, 0), Quaternion.Euler(0, 0, 0));
            Instantiate(explo, this.transform.position + new Vector3(0, 0, 2), Quaternion.Euler(0, 0, 0));
            Instantiate(explo, this.transform.position + new Vector3(0, 0, -2), Quaternion.Euler(0, 0, 0));

            //Invoke("Explo", 0.1f);
            
            Destroy(this.gameObject);
        }
    }


    /*void Explo()
    {
        Instantiate(explo, this.transform.position, Quaternion.Euler(0, 0, 0));
        Instantiate(explo, this.transform.position + new Vector3(2, 0, 0), Quaternion.Euler(0, 0, 0));
        Instantiate(explo, this.transform.position + new Vector3(-2, 0, 0), Quaternion.Euler(0, 0, 0));
        Instantiate(explo, this.transform.position + new Vector3(0, 0, 2), Quaternion.Euler(0, 0, 0));
        Instantiate(explo, this.transform.position + new Vector3(0, 0, -2), Quaternion.Euler(0, 0, 0));
    }*/
}
