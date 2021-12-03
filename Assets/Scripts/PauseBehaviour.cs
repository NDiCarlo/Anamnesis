using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseBehaviour : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject restart;
    public GameObject resume;
    public GameObject howToPlay;

    public GameObject player;

    public void Resume()
    {
        Time.timeScale = 1;
        mainMenu.SetActive(false);
        restart.SetActive(false);
        resume.SetActive(false);
        howToPlay.SetActive(false);

        player.GetComponent<SpriteRenderer>().enabled = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void ResetButton()
    {
        player.GetComponent<SpriteRenderer>().enabled = true;
        Time.timeScale = 1;

        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene);
    }
}