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

    public SpriteRenderer moveTowardsRed;
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
            rb.MovePosition(Vector3.MoveTowards(transform.position,
                                             player.position,
                                             Time.deltaTime * speed));
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

            StartCoroutine(hitFeedback());

            if (health == 0)
            {
                Destroy(gameObject);
                GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();

                gc.numberofEnemies--;
            }
            if (health == 5)
            {
                MoveTowards.transform.localScale = new Vector3(.95f, .95f);
            }
            if (health == 4)
            {
                MoveTowards.transform.localScale = new Vector3(.85f, .85f);
            }
            if (health == 3)
            {
                MoveTowards.transform.localScale = new Vector3(.75f, .75f);
            }
            if (health == 2)
            {
                MoveTowards.transform.localScale = new Vector3(.65f, .65f);
            }
            if (health == 1)
            {
                MoveTowards.transform.localScale = new Vector3(.60f, .60f);
            }
        }
        if (collidedObject.name.Contains("Weapon Spear"))
        {
            health--;

            StartCoroutine(hitFeedback());

            if (health == 0)
            {
                Destroy(gameObject);
                GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();

                gc.numberofEnemies--;
            }
            if (health == 5)
            {
                MoveTowards.transform.localScale = new Vector3(.95f, .95f);
            }
            if (health == 4)
            {
                MoveTowards.transform.localScale = new Vector3(.85f, .85f);
            }
            if (health == 3)
            {
                MoveTowards.transform.localScale = new Vector3(.75f, .75f);
            }
            if (health == 2)
            {
                MoveTowards.transform.localScale = new Vector3(.65f, .65f);
            }
            if (health == 1)
            {
                MoveTowards.transform.localScale = new Vector3(.60f, .60f);
            }
        }
        if (collidedObject.name.Contains("Arrow"))
        {
            health--;

            StartCoroutine(hitFeedback());

            if (health == 0)
            {
                Destroy(gameObject);
                GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();

                gc.numberofEnemies--;
            }
            if (health == 5)
            {
                MoveTowards.transform.localScale = new Vector3(.95f, .95f);
            }
            if (health == 4)
            {
                MoveTowards.transform.localScale = new Vector3(.85f, .85f);
            }
            if (health == 3)
            {
                MoveTowards.transform.localScale = new Vector3(.75f, .75f);
            }
            if (health == 2)
            {
                MoveTowards.transform.localScale = new Vector3(.65f, .65f);
            }
            if (health == 1)
            {
                MoveTowards.transform.localScale = new Vector3(.60f, .60f);
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