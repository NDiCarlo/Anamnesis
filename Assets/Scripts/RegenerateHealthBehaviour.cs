using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegenerateHealthBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RegenHealth", 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RegenHealth()
    {
        if (SceneManager.GetActiveScene().name == "LoverScene")
        {
            PlayerBehaviour pb = GameObject.FindObjectOfType<PlayerBehaviour>
                ();

            if (pb.health < pb.maxHealth && Time.time > (pb.timestamp + 5f))
            {
                pb.health++;
                pb.RegenHealth = true;
            }

        }
        if (SceneManager.GetActiveScene().name == "ParentLevel")
        {
            PlayerBehaviourParent pb = GameObject.FindObjectOfType<PlayerBehaviourParent>
                ();

            if (pb.health < pb.maxHealth && Time.time > (pb.timestamp + 5f))
            {
                pb.health++;
                pb.RegenHealth = true;
            }
        }
        if (SceneManager.GetActiveScene().name == "ChildLevelScene")
        {
            PlayerBehaviourChildLevel pb = GameObject.FindObjectOfType<PlayerBehaviourChildLevel>
                ();

            if (pb.health < pb.maxHealth && Time.time > (pb.timestamp + 5f))
            {
                pb.health++;
                pb.RegenHealth = true;
            }
        }
    }
}