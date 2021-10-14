using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsEnemyBehaviour : MonoBehaviour
{
    private Transform player;

    public int health;

    private Rigidbody2D rb;

    public GameObject MoveTowards;
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
        Vector3 newPos = Vector3.MoveTowards(transform.position,
                                               player.position,
                                               Time.deltaTime * speed);
        transform.position = newPos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("Player"))
        {
            PlayerBehaviour pb = GameObject.FindObjectOfType<PlayerBehaviour>
                ();

            pb.health--;


        }
        if (collidedObject.name.Contains("Bullet"))
        {
            health--;

            if (health == 0)
            {
                Destroy(gameObject);
                GameController gc = GameObject.FindObjectOfType<GameController>
                ();

                gc.numberofEnemies--;
            }

        }
    }
}
