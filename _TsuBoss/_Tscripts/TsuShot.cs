using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsuShot : MonoBehaviour
{
    public AudioClip tjakuSound;
    private AudioSource tjakusource;
    public AudioClip tkyouSound;
    private AudioSource tkyousource;
    public AudioClip tfinalSound;
    private AudioSource tfinalsource;

    public GameObject[] tjakubllet;
    //private Animator tanimator;


    // Start is called before the first frame update
    void Start()
    {
        tjakusource = GetComponent<AudioSource>();
        tkyousource = GetComponent<AudioSource>();
        tfinalsource = GetComponent<AudioSource>();
        //this.tanimator = GetComponent<Animator>();
        StartCoroutine("TJakuShot");
        StartCoroutine("Tsubom");
        StartCoroutine("TsubomFinal");
        StartCoroutine("Action");
    }

    int vmax = 4;
    int hmax = 10;
    int hmin = 6;

    int[] v = { -2, 0, 2 };
    int[] h = { -2, 0, 2 };

    IEnumerator Action()
    {

        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            int vr = UnityEngine.Random.Range(0, 3);
            int hr = UnityEngine.Random.Range(0, 3);

            Transform enemyTrans = GameObject.Find("Tuboss").transform;
            Vector3 pos = enemyTrans.position;


            float result_x = pos.x + v[vr];
            float result_z = pos.z + h[hr];

            if (result_x < 0 || result_x > vmax)
            {
                result_x = pos.x;
            }

            if (result_z < hmin || result_z > hmax)
            {
                result_z = pos.z;
            }

            pos.x = result_x;
            pos.z = result_z;

            enemyTrans.position = pos;

        }

    }

    IEnumerator TJakuShot()
    {
        Vector3 pos = transform.position;

        while (true)
        {
            int r = UnityEngine.Random.Range(0, 3);
            yield return new WaitForSeconds(1.2f);
            //GetComponent<Animator>().SetTrigger("isTJaku");
            tjakusource.PlayOneShot(tjakuSound, 1);
            Instantiate(tjakubllet[r], transform.position, Quaternion.Euler(0, 180, 0));

        }
    }

    public GameObject tsubom;

    IEnumerator Tsubom()
    {
        Vector3 pos = transform.position;

        while (true)
        {

            yield return new WaitForSeconds(5f);
            //GetComponent<Animator>().SetTrigger("isTsubom");
            tkyousource.PlayOneShot(tkyouSound, 1);
            Instantiate(tsubom, transform.position, transform.rotation);
        }
    }


    public GameObject tsubomfinal;

    IEnumerator TsubomFinal()
    {
        while (true)
        {
            print("tfinal");
            yield return new WaitForSeconds(11f);
            //GetComponent<Animator>().SetTrigger("isTFinal");
            tfinalsource.PlayOneShot(tfinalSound, 5);
            Instantiate(tsubomfinal, transform.position, transform.rotation);
        }
    }



    // Update is called once per frame
    void Update()
    {

    }
}

