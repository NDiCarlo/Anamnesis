/*****************************************************************************
// File Name :         QuitApplication.cs
// Author :            Nolan DiCarlo
// Creation Date :     November 25, 2021
//
// Brief Description: This is how ypu are able to exit out of the exported
game

*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
