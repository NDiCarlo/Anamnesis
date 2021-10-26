using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryBulletBehaviourParentLevel : MonoBehaviour
{
    public float speed = 5;

    private Rigidbody2D rb;

    public float lifetime;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        findPlayer();
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public PlayerBehaviourParent target;

    private Vector2 moveDirection;

    void findPlayer()
    {
        target = GameObject.FindObjectOfType<PlayerBehaviourParent>();
        moveDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("Walls"))
        {
            Destroy(gameObject);
        }
        if (collidedObject.name.Contains("Player"))
        {
            PlayerBehaviourParent pb = GameObject.FindObjectOfType<PlayerBehaviourParent>();

            pb.health--;

            Destroy(gameObject);
        }
        if (collidedObject.name.Contains("MoveTowardsEnemyParent"))
        {
            Destroy(gameObject);
        }
        if (collidedObject.name.Contains("Bullet Parent"))
        {
            Destroy(gameObject);
        }
    }
}
