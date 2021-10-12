using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowKeyBulletBehaviour : MonoBehaviour
{
    public float xSpeed;

    public float ySpeed;

    public float Lifetime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x += xSpeed * Time.deltaTime;
        position.y += ySpeed * Time.deltaTime;
        transform.position = position;
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
