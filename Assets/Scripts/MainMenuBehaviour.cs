using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBehaviour : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("DialogueScene");
    }

    public void GoToControls()
    {
        SceneManager.LoadScene("ControlsScene");
    }

    public void GoBack()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
