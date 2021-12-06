/*****************************************************************************
// File Name :         UIButtonBehaviour.cs
// Author :            Nolan DiCarlo, Justin Clemens
// Creation Date :     October 23, 2021
//
// Brief Description : Loads scenes on the dialogues scenes and restarts the
scene
*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonBehahviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartLevel(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void gotoLoverClosed()
    {
        SceneManager.LoadScene("LoverScene");
    }
    public void gotoLoverOpen()
    {
        SceneManager.LoadScene("LoverLevelOpenScene");
    }
}
