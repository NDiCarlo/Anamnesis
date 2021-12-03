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

        if (PlayerBehaviour.isRead == true)
        {
            pb.bulletImage.SetActive(true);
            pb.arrowImage.SetActive(true);
            pb.health1.enabled = true;
            pb.health2.enabled = true;
            pb.health3.enabled = true;
            pb.health4.enabled = true;
            pb.health5.enabled = true;
            pb.weaponBar.enabled = true;
        }
        if (PlayerBehaviour.isRead == false)
        {
            pb.bulletImage.SetActive(true);
            pb.arrowImage.SetActive(false);
            pb.weaponBar.enabled = true;
            pb.health1.enabled = true;
            pb.health2.enabled = true;
            pb.health3.enabled = true;
            pb.health4.enabled = true;
            pb.health5.enabled = true;
        }
    }
    public void UnpauseGame1()
    {
        Time.timeScale = 1;

        PlayerBehaviourChildLevel pb1 = GameObject.FindObjectOfType<PlayerBehaviourChildLevel>
            ();

        if (PlayerBehaviourChildLevel.isRead == true && PlayerBehaviour.isRead == true)
        {
            pb1.bulletImage.SetActive(true);
            pb1.arrowImage.SetActive(true);
            pb1.spearImage.SetActive(true);
            pb1.weaponBar.enabled = true;
            pb1.health1.enabled = true;
            pb1.health2.enabled = true;
            pb1.health3.enabled = true;
            pb1.health4.enabled = true;
            pb1.health5.enabled = true;
        }
        if (PlayerBehaviourChildLevel.isRead == true && PlayerBehaviour.isRead == false)
        {
            pb1.bulletImage.SetActive(true);
            pb1.arrowImage.SetActive(false);
            pb1.spearImage.SetActive(true);
            pb1.weaponBar.enabled = true;
            pb1.health1.enabled = true;
            pb1.health2.enabled = true;
            pb1.health3.enabled = true;
            pb1.health4.enabled = true;
            pb1.health5.enabled = true;
        }
        if (PlayerBehaviourChildLevel.isRead == false && PlayerBehaviour.isRead == true)
        {
            pb1.bulletImage.SetActive(true);
            pb1.arrowImage.SetActive(true);
            pb1.spearImage.SetActive(false);
            pb1.weaponBar.enabled = true;
            pb1.health1.enabled = true;
            pb1.health2.enabled = true;
            pb1.health3.enabled = true;
            pb1.health4.enabled = true;
            pb1.health5.enabled = true;
        }

        if (PlayerBehaviourChildLevel.isRead == false && PlayerBehaviour.isRead == false)
        {
            pb1.bulletImage.SetActive(true);
            pb1.arrowImage.SetActive(false);
            pb1.spearImage.SetActive(false);
            pb1.weaponBar.enabled = true;
            pb1.health1.enabled = true;
            pb1.health2.enabled = true;
            pb1.health3.enabled = true;
            pb1.health4.enabled = true;
            pb1.health5.enabled = true;
        }
    }
        public void UnpauseGame2()
        {
            Time.timeScale = 1;

            PlayerBehaviourParent pb2 = GameObject.FindObjectOfType<PlayerBehaviourParent>
                ();

        if (PlayerBehaviourChildLevel.isRead == true && PlayerBehaviour.isRead == true)
        {
            pb2.bulletImage.SetActive(true);
            pb2.arrowImage.SetActive(true);
            pb2.spearImage.SetActive(true);
            pb2.musicBoxImage.SetActive(true);
            pb2.health1.enabled = true;
            pb2.health2.enabled = true;
            pb2.health3.enabled = true;
            pb2.health4.enabled = true;
            pb2.health5.enabled = true;
            pb2.weaponBar.enabled = true;
        }
        if (PlayerBehaviourChildLevel.isRead == true && PlayerBehaviour.isRead == false)
        {
            pb2.bulletImage.SetActive(true);
            pb2.arrowImage.SetActive(false);
            pb2.spearImage.SetActive(true);
            pb2.musicBoxImage.SetActive(true);
            pb2.health1.enabled = true;
            pb2.health2.enabled = true;
            pb2.health3.enabled = true;
            pb2.health4.enabled = true;
            pb2.health5.enabled = true;
            pb2.weaponBar.enabled = true;
        }
        if (PlayerBehaviourChildLevel.isRead == false && PlayerBehaviour.isRead == true)
        {
            pb2.bulletImage.SetActive(true);
            pb2.arrowImage.SetActive(true);
            pb2.spearImage.SetActive(false);
            pb2.musicBoxImage.SetActive(true);
            pb2.health1.enabled = true;
            pb2.health2.enabled = true;
            pb2.health3.enabled = true;
            pb2.health4.enabled = true;
            pb2.health5.enabled = true;
            pb2.weaponBar.enabled = true;
        }
        if (PlayerBehaviourChildLevel.isRead == false && PlayerBehaviour.isRead == false)
        {
            pb2.bulletImage.SetActive(true);
            pb2.arrowImage.SetActive(false);
            pb2.spearImage.SetActive(false);
            pb2.musicBoxImage.SetActive(true);
            pb2.health1.enabled = true;
            pb2.health2.enabled = true;
            pb2.health3.enabled = true;
            pb2.health4.enabled = true;
            pb2.health5.enabled = true;
            pb2.weaponBar.enabled = true;
        }
    }
}

