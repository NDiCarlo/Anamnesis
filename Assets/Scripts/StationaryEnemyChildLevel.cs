using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryEnemyChildLevel : MonoBehaviour
{
    public float fireRate;
    public float nextFire;

    public GameObject bullet;

    public Transform player;

    public int health;

    public float range;
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
        if (Time.time > nextFire && (Vector2.Distance(transform.position, player.position) >= range))
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
                GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();

                gc.numberofEnemies--;

                Destroy(gameObject);
            }
            if (health == 5)
            {
                transform.localScale = new Vector2(.9f, .9f);
            }
            if (health == 4)
            {
                transform.localScale = new Vector2(.8f, .8f);
            }
            if (health == 3)
            {
                transform.localScale = new Vector2(.7f, .7f);
            }
            if (health == 2)
            {
                transform.localScale = new Vector2(.6f, .6f);
            }
            if (health == 1)
            {
                transform.localScale = new Vector2(.5f, .5f);
            }
            if (collidedObject.name.Contains("Player"))
            {
                PlayerBehaviourChildLevel pb = GameObject.FindObjectOfType<PlayerBehaviourChildLevel>
                    ();

                pb.health--;

            }
        }
            if (collidedObject.name.Contains("Weapon Spear"))
            {
                health--;

                if (health == 0)
                {
                    Destroy(gameObject);
                    GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                    ();

                    gc.numberofEnemies--;
                }
                if (health == 5)
                {
                    transform.localScale = new Vector2(.9f, .9f);
                }
                if (health == 4)
                {
                    transform.localScale = new Vector2(.8f, .8f);
                }
                if (health == 3)
                {
                    transform.localScale = new Vector2(.7f, .7f);
                }
                if (health == 2)
                {
                    transform.localScale = new Vector2(.6f, .6f);
                }
                if (health == 1)
                {
                    transform.localScale = new Vector2(.5f, .5f);
                }
            }
        if (collidedObject.name.Contains("Arrow"))
        {
            health--;

            if (health == 0)
            {
                Destroy(gameObject);
                GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();

                gc.numberofEnemies--;
            }
            if (health == 5)
            {
                transform.localScale = new Vector2(.9f, .9f);
            }
            if (health == 4)
            {
                transform.localScale = new Vector2(.8f, .8f);
            }
            if (health == 3)
            {
                transform.localScale = new Vector2(.7f, .7f);
            }
            if (health == 2)
            {
                transform.localScale = new Vector2(.6f, .6f);
            }
            if (health == 1)
            {
                transform.localScale = new Vector2(.5f, .5f);
            }
        }
    }
    }
