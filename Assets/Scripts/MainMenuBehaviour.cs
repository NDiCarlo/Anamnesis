using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuBehaviour : MonoBehaviour
{

    public GameObject ControlsImage;

    public GameObject MainMenuImage;
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
       ControlsImage.gameObject.SetActive(true);
       MainMenuImage.gameObject.SetActive(false);
    }

    public void GoBack()
    {
        ControlsImage.gameObject.SetActive(false);
        MainMenuImage.gameObject.SetActive(true);
    }
}
