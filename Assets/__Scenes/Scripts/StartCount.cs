using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartCount : MonoBehaviour
{
    public Text _textCountdown;
    

    void Start()
    {
        Time.timeScale = 0;
        _textCountdown.text = "";
        
    }

    

    int timer = 250;

    void Update()
    {
        timer--;

        if (timer == 240)
        {
            _textCountdown.text = "3";
        }

        if (timer == 180)
        {
            _textCountdown.text = "2";
        }
        if (timer == 120)
        {
            _textCountdown.text = "1";
        }
        if (timer == 60)
        {
            _textCountdown.text = "GO!";
        }
        if (timer < 0)
        { 
            Time.timeScale = 1;
            _textCountdown.gameObject.SetActive(false);
        }
    }
}