using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{

    public GameObject jakubllet;
    private Animator animator;
   
    
    // Start is called before the first frame update
    void Start()
    {
        //this.animator = GetComponent<Animator>();
        StartCoroutine("JakuShot");
    }


    IEnumerator JakuShot()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(1.2f);
            GetComponent<Animator>().SetTrigger("isJaku");
            Instantiate(jakubllet, transform.position, transform.rotation);
            
        }
    }
   

        // Update is called once per frame
        void Update()
        {
        
        }
}
