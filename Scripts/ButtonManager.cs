using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void SayTheNumberScene()
    {
        SceneManager.LoadScene("Number Game Say Number");
    }

    public void WhichNumberIsThisScene()
    {
        SceneManager.LoadScene("Number Game Which one is it");
    }

    public void PlaceTheNumberScene()
    {
        SceneManager.LoadScene("Number Game Place Numbers");
    }

    public void MainMenuScene()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
