/*****************************************************************************
// File Name :         MoveTowardsEnemyParentLevel.cs
// Author :            Nolan DiCarlo
// Creation Date :     September 25, 2021
//
// Brief Description: This is how the MoveTowards enemy moves
for the parent level, collision, and how the enemy gets smaller when hit and hit
feedback

*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsEnemyParentLevel : MonoBehaviour
{
    private Transform player;

    public int health;

    private Rigidbody2D rb;

    public GameObject MoveTowards;

    public float range;

    public SpriteRenderer moveTowardsRed;
    // Start is called before the first frame update
    void Start()
    {
        GameObject playerGO = GameObject.Find("Player");
        player = playerGO.transform;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        enemyMovement();
    }
    public float speed = 0.5f;
    void enemyMovement()
    {
        if (Vector2.Distance(transform.position, player.position) <= range)
        {
            rb.MovePosition(Vector3.MoveTowards(transform.position,
                                             player.position,
                                             Time.deltaTime * speed));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("Bullet Parent"))
        {
            health--;

            StartCoroutine(hitFeedback());

            if (health == 0)
            {
                Destroy(gameObject);
                GameControllerParent gc = GameObject.FindObjectOfType<GameControllerParent>
               ();
                gc.numberofEnemies--;
            }
            if (health == 5)
            {
                MoveTowards.transform.localScale = new Vector2(1.4f, 1.4f);
            }
            if (health == 4)
            {
                MoveTowards.transform.localScale = new Vector2(1.3f, 1.3f);
            }
            if (health == 3)
            {
                MoveTowards.transform.localScale = new Vector2(1.2f, 1.2f);
            }
            if (health == 2)
            {
                MoveTowards.transform.localScale = new Vector2(1.1f, 1.1f);
            }
            if (health == 1)
            {
                MoveTowards.transform.localScale = new Vector2(1f, 1f);
            }
        }
        if (collidedObject.name.Contains("Weapon Spear"))
        {
            health--;

            StartCoroutine(hitFeedback());

            if (health == 0)
            {
                Destroy(gameObject);
                GameControllerParent gc = GameObject.FindObjectOfType<GameControllerParent>
                ();

                gc.numberofEnemies--;
            }
            if (health == 5)
            {
                MoveTowards.transform.localScale = new Vector2(1.4f, 1.4f);
            }
            if (health == 4)
            {
                MoveTowards.transform.localScale = new Vector2(1.3f, 1.3f);
            }
            if (health == 3)
            {
                MoveTowards.transform.localScale = new Vector2(1.2f, 1.2f);
            }
            if (health == 2)
            {
                MoveTowards.transform.localScale = new Vector2(1.1f, 1.1f);
            }
            if (health == 1)
            {
                MoveTowards.transform.localScale = new Vector2(1f, 1f);
            }
        }
        if (collidedObject.name.Contains("Player"))
        {
            Destroy(gameObject);
            GameControllerParent gc = GameObject.FindObjectOfType<GameControllerParent>
           ();
            gc.numberofEnemies--;
        }
        if (collidedObject.name.Contains("Arrow"))
        {
            health -= 2;

            StartCoroutine(hitFeedback());

            if (health <= 0)
            {
                Destroy(gameObject);
                GameControllerParent gc = GameObject.FindObjectOfType<GameControllerParent>
                ();

                gc.numberofEnemies--;
            }
            if (health == 5)
            {
                MoveTowards.transform.localScale = new Vector2(1.4f, 1.4f);
            }
            if (health == 4)
            {
                MoveTowards.transform.localScale = new Vector2(1.3f, 1.3f);
            }
            if (health == 3)
            {
                MoveTowards.transform.localScale = new Vector2(1.2f, 1.2f);
            }
            if (health == 2)
            {
                MoveTowards.transform.localScale = new Vector2(1.1f, 1.1f);
            }
            if (health == 1)
            {
                MoveTowards.transform.localScale = new Vector2(1f, 1f);
            }
        }
    }

    private IEnumerator hitFeedback()
    {
        moveTowardsRed.color = Color.red;

        yield return new WaitForSeconds(.1f);

        moveTowardsRed.color = Color.grey;
    }
}