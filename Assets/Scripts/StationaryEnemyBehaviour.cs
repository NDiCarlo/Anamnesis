using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryEnemyBehaviour : MonoBehaviour
{
    public float fireRate;
    public float nextFire; 

    public GameObject bullet;

    public Transform player;

    public int health;
    // Start is called before the first frame update
    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        checktimetoFire();
    }
    void checktimetoFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            nextFire = Time.time + fireRate;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("Bullet"))
        {
            health--;

            if (health == 0)
            {
                GameController gc = GameObject.FindObjectOfType<GameController>
                ();

                gc.numberofEnemies--;

                Destroy(gameObject);
            }
        }
    }
}
