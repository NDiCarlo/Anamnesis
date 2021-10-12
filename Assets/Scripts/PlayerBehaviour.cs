using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 5;

    public GameObject scenePanel;

    public GameObject TriggerFirstRoomEnemies;

    public GameObject TriggerSecondRoomEnemies;

    public GameObject TriggerThirdRoomEnemies;

    public int health = 999;

    public GameObject Bullet;

    public float TimeBetweenShots;

    public GameObject bulletarrowKeys;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        Shooting();
        Shooting2();
    }

    void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        float yMove = Input.GetAxis("Vertical");
        float xMove = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2();

        movement.x = xMove;
        movement.y = yMove;

        movement *= Time.fixedDeltaTime * speed;

        rb.MovePosition(rb.position + movement);
    }

    void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject go = (GameObject)Instantiate(bulletarrowKeys,
                transform.position, transform.rotation);

            go.GetComponent<ArrowKeyBulletBehaviour>().ySpeed = 27f;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject go = (GameObject)Instantiate(bulletarrowKeys,
                transform.position, transform.rotation);

            go.GetComponent<ArrowKeyBulletBehaviour>().xSpeed = -27;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GameObject go = (GameObject)Instantiate(bulletarrowKeys,
                 transform.position, transform.rotation);

            go.GetComponent<ArrowKeyBulletBehaviour>().ySpeed = -27f;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject go = (GameObject)Instantiate(bulletarrowKeys,
                transform.position, transform.rotation);

            go.GetComponent<ArrowKeyBulletBehaviour>().xSpeed = 27f;
        }
    }

    void Shooting2()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet, transform.position, transform.rotation);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("Door"))
        {
            scenePanel.gameObject.SetActive(true);
        }
        if (collidedObject.name.Contains("Trigger First Room Enemies"))
        {
            GameController gc = GameObject.FindObjectOfType<GameController>
                ();
            gc.spawnMoveTowardsEnemy();
            gc.spawnStationaryEnemy();
            Destroy(TriggerFirstRoomEnemies);
        }
        if (collidedObject.name.Contains("Trigger Second Room Enemies"))
        {
            GameController gc = GameObject.FindObjectOfType<GameController>
                ();
            gc.spawnMoveTowardsEnemy2();
            gc.spawnStationaryEnemy2();
            Destroy(TriggerSecondRoomEnemies);
        }
        if (collidedObject.name.Contains("Trigger Third Room Enemies"))
        {
            GameController gc = GameObject.FindObjectOfType<GameController>
                ();
            gc.spawnMoveTowardsEnemy3();
            gc.spawnStationaryEnemy3();
            Destroy(TriggerThirdRoomEnemies);
        }
    }
}