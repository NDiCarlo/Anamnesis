/*****************************************************************************
// File Name :         DialogueB.cs
// Author :            Nolan DiCarlo
// Creation Date :     September 25, 2021
//
// Brief Description: This is the script on how the text is able to
be scrolling text and go across the screen

*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueB : MonoBehaviour
{
    private float waitTime = .04f;
    private Text showText;
    public string input;
    private void Awake()
    {
        showText = GetComponent<Text>();
        showText.text = "";
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WriteText(input, showText));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            waitTime = 0.00f;
        }
    }
    protected IEnumerator WriteText(string input, Text showText)
    { 
        for (int i = 0; i < input.Length; i++)
        {
            showText.text += input[i];
            yield return new WaitForSecondsRealtime(waitTime);
        }
    }
}