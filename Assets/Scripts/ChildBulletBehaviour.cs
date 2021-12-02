using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildBulletBehaviour : MonoBehaviour
{
    public float lifeTime = 2f;
    public float speed = 5f;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        findPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        ScytheMovement();
    }

    public void ScytheMovement()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
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
    }
}