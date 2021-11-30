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
    public void LoadScene1()
    {
        SceneManager.LoadScene("ChildLevelScene");
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene("ChildLevelOpenScene");
    }
    public void LoadScene3()
    {
        SceneManager.LoadScene("ParentLevelOpen");
    }
    public void LoadScene4()
    {
        SceneManager.LoadScene("ParentLevel");
    }
}
