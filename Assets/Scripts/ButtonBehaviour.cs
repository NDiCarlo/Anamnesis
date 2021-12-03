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

    public void UnpauseGame()
    {
        Time.timeScale = 1;

        PlayerBehaviour pb = GameObject.FindObjectOfType<PlayerBehaviour>
                ();

        pb.health1.enabled = true;
        pb.health2.enabled = true;
        pb.health3.enabled = true;
        pb.health4.enabled = true;
        pb.health5.enabled = true;

        PlayerBehaviourChildLevel pb1 = GameObject.FindObjectOfType<PlayerBehaviourChildLevel>
                ();

        pb1.health1.enabled = true;
        pb1.health2.enabled = true;
        pb1.health3.enabled = true;
        pb1.health4.enabled = true;
        pb1.health5.enabled = true;

        PlayerBehaviourParent pb2 = GameObject.FindObjectOfType<PlayerBehaviourParent>
                ();

        pb2.health1.enabled = true;
        pb2.health2.enabled = true;
        pb2.health3.enabled = true;
        pb2.health4.enabled = true;
        pb2.health5.enabled = true;
    }
}
