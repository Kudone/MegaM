using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("JakuShot");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject jakubllet;

    IEnumerator JakuShot()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.2f);
                Instantiate(jakubllet, transform.position, transform.rotation);
        }
    }

}
