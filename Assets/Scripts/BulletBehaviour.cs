using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float Lifetime;

    private Vector2 target;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Lifetime);
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target,
            speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("Walls"))
        {
            Destroy(gameObject);
        }

        if (collidedObject.name.Contains("Enemy Walls"))
        {
            Destroy(gameObject);
        }
    }
}