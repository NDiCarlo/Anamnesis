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
        }
    }
}
