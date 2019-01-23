using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Medical");
    }

    public GameObject medical;

    IEnumerator Medical()
    {
        while (true)
        {
            yield return new WaitForSeconds(20f);
            float rx = UnityEngine.Random.Range(0, 3) * 2;
            float rz = UnityEngine.Random.Range(0, 3) * 2;
            Instantiate(medical, new Vector3(rx, 0.5f, rz), transform.rotation);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
