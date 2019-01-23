using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("GameOverCS", 1.0f);
    }

    void GameOverCS()
    {
        SceneManager.LoadScene("GameOver");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
