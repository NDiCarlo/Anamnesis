using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildBulletBehaviour : MonoBehaviour
{
    public float lifeTime = 2f;
    public float speed = 5f;
    private Vector3 direction;
    private Rigidbody2D rb;
    Vector3 playerPosition;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        findPlayer();
        playerPosition = Camera.main.ScreenToWorldPoint(playerPosition);
        playerPosition.z = 0f;
        direction = (playerPosition - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
        ScytheMovement();
    }

    public void ScytheMovement()
    {
        transform.position += direction * speed * Time.deltaTime;
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