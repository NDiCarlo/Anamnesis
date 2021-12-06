/*****************************************************************************
// File Name :         ActivateArt.cs
// Author :            Justin Clemens
// Creation Date :     November 21, 2021
//
// Brief Description : Just sets the Art Gameobject to true
*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateArt : MonoBehaviour
{
    public GameObject gOject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        gOject.SetActive(true);
    }
}
