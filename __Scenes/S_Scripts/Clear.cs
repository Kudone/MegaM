using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("GotoClaer",2.0f);
    }
 public void GotoClear()
    {
        SceneManager.LoadScene("Clear");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
