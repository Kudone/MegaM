using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 0.7f);
        StartCoroutine("ColliderActive");
    }

    IEnumerator ColliderActive()
    {
        yield return new WaitForSeconds(0.5f);
        GetComponent<SphereCollider>().enabled = !GetComponent<SphereCollider>().enabled;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
