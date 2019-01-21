using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void Action()
    {
        int vmax = 4;
        int hmax = 4;

        Transform myTrans = GameObject.Find("MyCharacter").transform;
        Vector3 pos = myTrans.position;

        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
        }

        if (Input.GetKeyDown("w") && pos.x != 0)
        {
            pos.x -= 2.0f;
        }

        if (Input.GetKeyDown("s") && pos.x < vmax)
        {
            pos.x += 2.0f;
            print("skey was pressed");
        }

        if (Input.GetKeyDown("a") && pos.z != 0)
        {
            pos.z -= 2.0f;
        }

        if (Input.GetKeyDown("d") && pos.z < hmax)
        {
            pos.z += 2.0f;
        }
        myTrans.position = pos;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Action();
    }
}
