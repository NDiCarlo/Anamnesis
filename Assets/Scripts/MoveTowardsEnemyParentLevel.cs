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

        if (collidedObject.name.Contains("Bullet Parent"))
        {
            health--;

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
            health--;

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
    }
}