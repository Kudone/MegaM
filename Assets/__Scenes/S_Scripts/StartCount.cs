using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartCount : MonoBehaviour
{
    public Text _textCountdown;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;

    void Start()
    {
        button1.GetComponent<Button>().interactable = false;
        button2.GetComponent<Button>().interactable = false;
        button3.GetComponent<Button>().interactable = false;
        button4.GetComponent<Button>().interactable = false;
        button5.GetComponent<Button>().interactable = false;
        button6.GetComponent<Button>().interactable = false;
        Time.timeScale = 0;
        _textCountdown.text = "";

    }



    int timer = 150;
    

    void Update()
    {
        timer--;

        if (timer == 140)
        {
            _textCountdown.text = "3";
        }

        if (timer == 100)
        {
            _textCountdown.text = "2";
        }
        if (timer == 60)
        {
            _textCountdown.text = "1";
        }
        if (timer == 20)
        {
            _textCountdown.text = "GO!";
        }
        if (timer < 0)
        {
            button1.GetComponent<Button>().interactable = true;
            button2.GetComponent<Button>().interactable = true;
            button3.GetComponent<Button>().interactable = true;
            button4.GetComponent<Button>().interactable = true;
            button5.GetComponent<Button>().interactable = true;
            button6.GetComponent<Button>().interactable = true;
            Time.timeScale = 1;
            _textCountdown.gameObject.SetActive(false);
            Destroy(this.gameObject, 1.0f);
        }
    }
}