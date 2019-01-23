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
}