using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueBehaviour : MonoBehaviour
{
    public Text startingText;
    public Button startingButton;
    public Text dialogueText1;
    public Button dialogueButton1;
    public Text dialogueText2;
    public Button dialogueButton2;
    public Text dialogueText3;
    public Button dialogueButton3;
    public Text dialogueText4;
    public Button dialogueButton4;
    public Text dialogueText5;
    public Button dialogueButton5;
    public Text dialogueText6;
    public Button dialogueButton6;
    public Button dialogueButton7;
    public Button dialogueButton72;
    public Text dialogueText8;
    public Button dialogueButton8;
    public Text dialogueText9;
    public Button dialogueButton9;
    public Text dialogueText10;
    public Button dialogueButton10;
    public Text dialogueText11;
    public Button dialogueButton11;
    public Text dialogueText12;
    public Button dialogueButton12;
    public Text dialogueText13;
    public Button dialogueButton13;
    public Button dialogueButton14;
    public Button dialogueButton142;
    public Text dialogueText15;
    public Button dialogueButton15;
    public Text dialogueText16;
    public Button dialogueButton16;
    public Text dialogueText17;
    public Button dialogueButton17;

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
        dialogueText1.gameObject.SetActive(true);
        dialogueButton1.gameObject.SetActive(true);

    }
    public void ContinueText1()
    {
        dialogueText1.gameObject.SetActive(false);
        dialogueButton1.gameObject.SetActive(false);
        dialogueText2.gameObject.SetActive(true);
        dialogueButton2.gameObject.SetActive(true);

    }

    public void ContinueText2()
    {
        dialogueText2.gameObject.SetActive(false);
        dialogueButton2.gameObject.SetActive(false);
        dialogueText3.gameObject.SetActive(true);
        dialogueButton3.gameObject.SetActive(true);
    }

    public void ContinueText3()
    {
        dialogueText3.gameObject.SetActive(false);
        dialogueButton3.gameObject.SetActive(false);
        dialogueText4.gameObject.SetActive(true);
        dialogueButton4.gameObject.SetActive(true);
    }
    public void ContinueText4()
    {
        dialogueText4.gameObject.SetActive(false);
        dialogueButton4.gameObject.SetActive(false);
        dialogueText5.gameObject.SetActive(true);
        dialogueButton5.gameObject.SetActive(true);
    }
    public void ContinueText5()
    {
        dialogueText5.gameObject.SetActive(false);
        dialogueButton5.gameObject.SetActive(false);
        dialogueText6.gameObject.SetActive(true);
        dialogueButton6.gameObject.SetActive(true);
    }
    public void ContinueText6()
    {
        dialogueText6.gameObject.SetActive(false);
        dialogueButton6.gameObject.SetActive(false);
        dialogueButton7.gameObject.SetActive(true);
        dialogueButton72.gameObject.SetActive(true);
    }
    public void ContinueText7()
    {
        dialogueButton7.gameObject.SetActive(false);
        dialogueButton72.gameObject.SetActive(false);
        dialogueText8.gameObject.SetActive(true);
        dialogueButton8.gameObject.SetActive(true);
    }
    public void ContinueText72()
    {
        dialogueButton7.gameObject.SetActive(false);
        dialogueButton72.gameObject.SetActive(false);
        dialogueText8.gameObject.SetActive(true);
        dialogueButton8.gameObject.SetActive(true);
    }
    public void ContinueText8()
    {
        dialogueText8.gameObject.SetActive(false);
        dialogueButton8.gameObject.SetActive(false);
        dialogueText9.gameObject.SetActive(true);
        dialogueButton9.gameObject.SetActive(true);
    }
    public void ContinueText9()
    {
        dialogueText9.gameObject.SetActive(false);
        dialogueButton9.gameObject.SetActive(false);
        dialogueText10.gameObject.SetActive(true);
        dialogueButton10.gameObject.SetActive(true);
    }
    public void ContinueText10()
    {
        dialogueText10.gameObject.SetActive(false);
        dialogueButton10.gameObject.SetActive(false);
        dialogueText11.gameObject.SetActive(true);
        dialogueButton11.gameObject.SetActive(true);
    }
    public void ContinueText11()
    {
        dialogueText11.gameObject.SetActive(false);
        dialogueButton11.gameObject.SetActive(false);
        dialogueText12.gameObject.SetActive(true);
        dialogueButton12.gameObject.SetActive(true);
    }
    public void ContinueText12()
    {
        dialogueText12.gameObject.SetActive(false);
        dialogueButton12.gameObject.SetActive(false);
        dialogueText13.gameObject.SetActive(true);
        dialogueButton13.gameObject.SetActive(true);
    }
    public void ContinueText13()
    {
        dialogueText13.gameObject.SetActive(false);
        dialogueButton13.gameObject.SetActive(false);
        dialogueButton14.gameObject.SetActive(true);
        dialogueButton142.gameObject.SetActive(true);
    }
    public void ContinueText14()
    {
        dialogueButton14.gameObject.SetActive(false);
        dialogueButton142.gameObject.SetActive(false);
        dialogueText15.gameObject.SetActive(true);
        dialogueButton15.gameObject.SetActive(true);
    }
    public void ContinueText15()
    {
        dialogueButton14.gameObject.SetActive(false);
        dialogueButton142.gameObject.SetActive(false);
        dialogueText16.gameObject.SetActive(true);
        dialogueButton16.gameObject.SetActive(true);
    }
    public void ContinueText16()
    {
        dialogueText16.gameObject.SetActive(false);
        dialogueButton16.gameObject.SetActive(false);
        dialogueText17.gameObject.SetActive(true);
        dialogueButton17.gameObject.SetActive(true);
    }
    public void LoadGameplayScene()
    {
        //change
        SceneManager.LoadScene("LoverScene");
    }
    public void LoadGameplayScene1()
    {
        //change
        SceneManager.LoadScene("LoverLevelOpenScene");
    }


}
