using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonBehaviour : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void dialogueScene()
    {
        SceneManager.LoadScene("DialogueScene2");
    }

    public void dialogueScene2()
    {
        SceneManager.LoadScene("DialogueScene3");
    }

    public void dialogueScene3()
    {
        SceneManager.LoadScene("DialogueScene4");
    }
}
