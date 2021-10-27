using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseBehaviour : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject restart;
    public GameObject resume;

    public void Resume()
    {
        Time.timeScale = 1;
        mainMenu.SetActive(false);
        restart.SetActive(false);
        resume.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void ResetButton()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene);
    }
}