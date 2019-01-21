using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
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

            Transform enemyTrans = GameObject.Find("EnemyCharacter").transform;
            Vector3 pos = enemyTrans.position;
            print(pos.x + "EnemyCharacter" + pos.z);

            float result_x = pos.x + v[vr];
            float result_z = pos.z + h[hr];

            if (result_x < 0 || result_x > vmax)
            {
                result_x = pos.x;
                print(result_x);
            }

            if (result_z < hmin || result_z > hmax)
            {
                result_z = pos.z;
                print(result_z);
            }

            pos.x = result_x;
            pos.z = result_z;
            enemyTrans.position = pos;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
