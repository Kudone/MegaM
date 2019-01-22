using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public AudioClip jakuSound;
    private AudioSource jakusource;
    public AudioClip kyouSound;
    private AudioSource kyousource;

    public GameObject jakubllet;
    private Animator animator;
   
    
    // Start is called before the first frame update
    void Start()
    {
        jakusource = GetComponent<AudioSource>();
        kyousource = GetComponent<AudioSource>();
        //this.animator = GetComponent<Animator>();
        StartCoroutine("JakuShot");
        StartCoroutine("FinalShot");
    }


    IEnumerator JakuShot()
    {
        Vector3 pos = transform.position;
        
        while (true)
        {
            
            yield return new WaitForSeconds(1.2f);
            GetComponent<Animator>().SetTrigger("isJaku");
            jakusource.PlayOneShot(jakuSound, 1);
            Instantiate(jakubllet, transform.position, transform.rotation);
            
        }
    }

    public GameObject spia;

    IEnumerator FinalShot()
    {
        Vector3 pos = transform.position;

        while (true)
        {

            yield return new WaitForSeconds(10f);
            GetComponent<Animator>().SetTrigger("isFinal");
            kyousource.PlayOneShot(kyouSound, 1);
            StartCoroutine("Spia");

        }
    }

    IEnumerator Spia()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(1.0f);
            float rx = UnityEngine.Random.Range(0, 3) * 2;
            float rz = UnityEngine.Random.Range(0, 3) * 2;
            Instantiate(spia, new Vector3(rx, 1.0f, rz), Quaternion.Euler(90, 0, 0));
        }
    }
    

    // Update is called once per frame
    void Update()
        {
        
        }
}
