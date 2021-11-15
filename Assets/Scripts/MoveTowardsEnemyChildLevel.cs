using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsEnemyChildLevel : MonoBehaviour
{
    private Transform player;

    public int health;

    private Rigidbody2D rb;

    public GameObject MoveTowards;

    public float range;
    // Start is called before the first frame update
    void Start()
    {
        GameObject playerGO = GameObject.Find("Player");
        player = playerGO.transform;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyMovement();
    }

    public float speed = 0.5f;
    void enemyMovement()
    {
        if (Vector2.Distance(transform.position, player.position) <= range)
        {
            Vector3 newPos = Vector3.MoveTowards(transform.position,
                                               player.position,
                                               Time.deltaTime * speed);
            transform.position = newPos;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("Player"))
        {
            Destroy(gameObject);
            GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();

            gc.numberofEnemies--;
        }

        if (collidedObject.name.Contains("Bullet"))
        {
            health--;

            if (health == 0)
            {
                Destroy(gameObject);
                GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();

                gc.numberofEnemies--;
            }
            if (health == 5)
            {
                MoveTowards.transform.localScale = new Vector2(.9f, .9f);
            }
            if (health == 4)
            {
                MoveTowards.transform.localScale = new Vector2(.8f, .8f);
            }
            if (health == 3)
            {
                MoveTowards.transform.localScale = new Vector2(.7f, .7f);
            }
            if (health == 2)
            {
                MoveTowards.transform.localScale = new Vector2(.6f, .6f);
            }
            if (health == 1)
            {
                MoveTowards.transform.localScale = new Vector2(.5f, .5f);
            }
        }
        if (collidedObject.name.Contains("Weapon Spear"))
        {
            health--;

            if (health == 0)
            {
                Destroy(gameObject);
                GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();

                gc.numberofEnemies--;
            }
            if (health == 5)
            {
                MoveTowards.transform.localScale = new Vector2(.9f, .9f);
            }
            if (health == 4)
            {
                MoveTowards.transform.localScale = new Vector2(.8f, .8f);
            }
            if (health == 3)
            {
                MoveTowards.transform.localScale = new Vector2(.7f, .7f);
            }
            if (health == 2)
            {
                MoveTowards.transform.localScale = new Vector2(.6f, .6f);
            }
            if (health == 1)
            {
                MoveTowards.transform.localScale = new Vector2(.5f, .5f);
            }
        }
        if (collidedObject.name.Contains("Arrow"))
        {
            health--;

            if (health == 0)
            {
                Destroy(gameObject);
                GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();

                gc.numberofEnemies--;
            }
            if (health == 5)
            {
                MoveTowards.transform.localScale = new Vector2(.9f, .9f);
            }
            if (health == 4)
            {
                MoveTowards.transform.localScale = new Vector2(.8f, .8f);
            }
            if (health == 3)
            {
                MoveTowards.transform.localScale = new Vector2(.7f, .7f);
            }
            if (health == 2)
            {
                MoveTowards.transform.localScale = new Vector2(.6f, .6f);
            }
            if (health == 1)
            {
                MoveTowards.transform.localScale = new Vector2(.5f, .5f);
            }
        }
    }
}