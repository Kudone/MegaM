using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Goto_game : MonoBehaviour
{
    public void Gotomain()
    {
        SceneManager.LoadScene("Main");
    }
    public void ButtonClicked()
    {
        Invoke("Gotomain", 1);
    }

    public void GotoTsu()
    {
        SceneManager.LoadScene("Tsuboss");
    }
    public void TsuButtonClicked()
    {
        Invoke("GotoTsu", 1);
    }

    public void SelectButtonClicked()
    {
        SceneManager.LoadScene("Select");
    }

    public void GotoTitle()
    {
        SceneManager.LoadScene("Title");
    }
    public void TitleButtonClicked()
    {
        Invoke("GotoTitle", 1);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {


            Application.Quit();

        }
    }


}