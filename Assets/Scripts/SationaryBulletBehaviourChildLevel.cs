using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SationaryBulletBehaviourChildLevel : MonoBehaviour
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

    public PlayerBehaviourChildLevel target;

    private Vector2 moveDirection;

    void findPlayer()
    {
        target = GameObject.FindObjectOfType<PlayerBehaviourChildLevel>();
        moveDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 10f);
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
                Destroy(gameObject);
        }
        if (collidedObject.name.Contains("MoveTowardEnemy"))
        {
            Destroy(gameObject);
        }
        if (collidedObject.name.Contains("Weapon Spear"))
        {
            Destroy(gameObject);
        }
        if (collidedObject.name.Contains("Bullet"))
        {
            Destroy(gameObject);
        }
        if (collidedObject.name.Contains("Secret Door"))
        {
            Destroy(gameObject);
        }
    }
}

