using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueB : MonoBehaviour
{
    public float waitTime = .07f;
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

    }
    protected IEnumerator WriteText(string input, Text showText)
    {
        for (int i = 0; i < input.Length; i++)
        {
            showText.text += input[i];
            yield return new WaitForSeconds(waitTime);
        }
    }
}
