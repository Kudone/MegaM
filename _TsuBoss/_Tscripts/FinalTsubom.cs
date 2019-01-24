using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTsubom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }



    public GameObject explo_particle;
    void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag == "stage")
        {
            Instantiate(explo_particle, new Vector3(0, 0, 0), Quaternion.Euler(270, 0, 0));
            Instantiate(explo_particle, new Vector3(0, 0, 2), Quaternion.Euler(270, 0, 0));
            Instantiate(explo_particle, new Vector3(0, 0, 4), Quaternion.Euler(270, 0, 0));
            Instantiate(explo_particle, new Vector3(2, 0, 0), Quaternion.Euler(270, 0, 0));
            Instantiate(explo_particle, new Vector3(2, 0, 2), Quaternion.Euler(270, 0, 0));
            Instantiate(explo_particle, new Vector3(2, 0, 4), Quaternion.Euler(270, 0, 0));
            Instantiate(explo_particle, new Vector3(4, 0, 0), Quaternion.Euler(270, 0, 0));
            Instantiate(explo_particle, new Vector3(4, 0, 2), Quaternion.Euler(270, 0, 0));
            Instantiate(explo_particle, new Vector3(4, 0, 4), Quaternion.Euler(270, 0, 0));


            //Invoke("Explo", 0.1f);

            Destroy(this.gameObject);
        }
    }


        // Update is called once per frame
        void Update()
    {
        
    }
}
