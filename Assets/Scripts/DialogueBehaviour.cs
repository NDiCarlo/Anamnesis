using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBehaviour : MonoBehaviour
{
    public Text startingText;
    public Button startingButton;
    public Text dialogueText1;
    public Button dialogueButton1;
    public Text dialogueText2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ContinueText()
    {
        startingText.enabled = false;
        startingButton.gameObject.SetActive(false);
        dialogueText1.enabled = true;
        dialogueButton1.gameObject.SetActive(true);

    }
    public void ContinueText1()
    {
        dialogueText1.enabled = false;
        dialogueButton1.gameObject.SetActive(false);
        dialogueText2.enabled = true;
    }



}
