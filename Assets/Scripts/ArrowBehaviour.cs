using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBehaviour : MonoBehaviour
{
    public float Lifetime;

    public float speed;

    Vector3 mousePosition;

    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Lifetime);
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;
        direction = (mousePosition - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
        arrowMovement();


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

        if (collidedObject.name.Contains("MoveTowardEnemy"))
        {
            Destroy(gameObject);
        }

        if (collidedObject.name.Contains("StationaryEnemy"))
        {
            Destroy(gameObject);
        }

        if (collidedObject.name.Contains("StationaryEnemyBullet"))
        {
            Destroy(gameObject);
        }

        if (collidedObject.name.Contains("MoveTowardsEnemyParent"))
        {
            Destroy(gameObject);
        }

        if (collidedObject.name.Contains("StationaryEnemyParent"))
        {
            Destroy(gameObject);
        }
        if (collidedObject.name.Contains("MoveTowardEnemyChildLevel"))
        {
            Destroy(gameObject);
        }

        if (collidedObject.name.Contains("StationaryEnemyChildLevel"))
        {
            Destroy(gameObject);
        }
        if (collidedObject.name.Contains("LoverLevelBoss"))
        {
            Destroy(gameObject);
        }
        if (collidedObject.name.Contains("ChildBoss"))
        {
            Destroy(gameObject);
        }
    }

    public void arrowMovement()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
