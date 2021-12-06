/*****************************************************************************
// File Name :         ParentBossBehaviour.cs
// Author :            Diego Hudelson
// Creation Date :     November 15, 2021
//
// Brief Description : This script is how the boss reacts and what the boss 
does when it is spawned in the parent level.
*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParentBossBehaviour : MonoBehaviour
{
    private Transform player;
    public float speed;
    public SpriteRenderer parentLevelBoss;
    public float range = 10f;
    public GameObject telegraph;
    public GameObject attack;
    public float health = 50;
    private IEnumerator ie;

    // Start is called before the first frame update
    void Start()
    {
        ie = BossBehaviour();

        StartCoroutine(ie);
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        if (health <= 0)
        {
            PlayerBehaviourParent pb = GameObject.FindObjectOfType<PlayerBehaviourParent>
                ();

            pb.health = 50;

            pb.door.SetActive(true);

            pb.afterBossDialogue.SetActive(true);

            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("Bullet"))
        {
            health--;
            StartCoroutine(hitBoss());
        }
        if (collidedObject.name.Contains("Arrow"))
        {
            health -= 2;
            StartCoroutine(hitBoss());
        }
        if (collidedObject.name.Contains("Weapon Spear"))
        {
            health--;
            StartCoroutine(hitBoss());
        }
    }

    private IEnumerator hitBoss()
    {
        parentLevelBoss.color = Color.red;

        yield return new WaitForSeconds(.1f);

        parentLevelBoss.color = Color.white;
    }
    public IEnumerator BossBehaviour()
    {
        yield return new WaitForSeconds(3f);

        parentLevelBoss.color = Color.red;

        yield return new WaitForSeconds(.10f);

        parentLevelBoss.color = Color.white;

        yield return new WaitForSeconds(.10f);

        parentLevelBoss.color = Color.red;

        yield return new WaitForSeconds(.5f);

        parentLevelBoss.color = Color.white;

        yield return new WaitForSeconds(.5f);

        Vector3 memorizePos = player.position;

        Instantiate(telegraph, memorizePos, transform.rotation);

        yield return new WaitForSeconds(.3f);

        Instantiate(attack, memorizePos, transform.rotation);

        StartCoroutine(ie);
    }

    // Call this function when the music box is activated
    public void musicBox()
    {
        StopCoroutine(ie);

        StartCoroutine(MusicBoxBehaviour());
    }

    private IEnumerator MusicBoxBehaviour()
    {

        parentLevelBoss.color = Color.red;

        yield return new WaitForSeconds(2f);

        parentLevelBoss.color = Color.white;

        yield return new WaitForSeconds(.5f);

        parentLevelBoss.color = Color.red;

        yield return new WaitForSeconds(.5f);

        parentLevelBoss.color = Color.white;

        StartCoroutine(ie);
    }
}