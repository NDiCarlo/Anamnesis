using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourChildLevel : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;

    public GameObject FirstRoomTrigger;

    public GameObject RoomTriggerLeft;

    public GameObject RoomTriggerRight;

    public GameObject LeftHallwayTrigger;

    public GameObject RightHallwayTrigger;

    public float health;

    public GameObject weaponSpear;

    public bool enableSpear;

    public float fireRate;

    public float nextFire;

    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enableSpear = false;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            enableSpear = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            enableSpear = true;
            weaponSpear.SetActive(true);
        }
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
    void Attack()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire && enableSpear == false)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Bullet, transform.position, transform.rotation);
            Bullet.gameObject.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire && enableSpear == true)
        {
            nextFire = Time.time + fireRate;
            Instantiate(weaponSpear, transform.position, transform.rotation);
            Bullet.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("1st Room Trigger"))
        {
            GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();
            gc.spawnMoveTowardsEnemy();
            gc.spawnStationaryEnemy();
            Destroy(FirstRoomTrigger);
        }
        if (collidedObject.name.Contains("Room Trigger Left"))
        {
            GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();
            gc.spawnMoveTowardsEnemy2();
            gc.spawnStationaryEnemy2();
            Destroy(RoomTriggerLeft);
        }
        if (collidedObject.name.Contains("Room Trigger Right"))
        {
            GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();
            gc.spawnMoveTowardsEnemy3();
            gc.spawnStationaryEnemy3();
            Destroy(RoomTriggerRight);
        }
        if (collidedObject.name.Contains("Hallway Trigger Left"))
        {
            GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();
            gc.spawnMoveTowardsEnemy4();
            gc.spawnStationaryEnemy4();
            Destroy(LeftHallwayTrigger);
        }
        if (collidedObject.name.Contains("Hallway Trigger Right"))
        {
            GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();
            gc.spawnMoveTowardsEnemy5();
            gc.spawnStationaryEnemy5();
            Destroy(RightHallwayTrigger);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;
    }
}