using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuBehaviour : MonoBehaviour
{

    public GameObject ControlsImage;

    public GameObject MainMenuImage;

    public GameObject CreditsImage;
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
        CreditsImage.gameObject.SetActive(false);
    }

    public void LoadControls()
    {
        ControlsImage.gameObject.SetActive(true);
    }

    public void Back()
    {
        ControlsImage.gameObject.SetActive(false);
    }

    public void LoadCredits()
    {
        CreditsImage.gameObject.SetActive(true);
    }

    public void LoadCredits1()
    {
        SceneManager.LoadScene("Credits");
    }
}
