using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourParent : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;

    public GameObject firstHallWayTrigger;

    public GameObject firstRoomTrigger;

    public GameObject secondHallWayTrigger;

    public GameObject Bullet;

    public float fireRate;

    public float nextFire;

    public GameObject weaponSpear;

    public bool enableSpear;

    public float health;

    public GameObject secondRoomTrigger;

    public GameObject thirdHallwayTrigger;

    public GameObject thirdRoomTrigger;

    public GameObject fourthHallwayTrigger;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enableSpear = false;
        GameControllerParent gc = GameObject.FindObjectOfType<GameControllerParent>
                ();

        gc.spawnMoveTowardsEnemy8();
        gc.spawnStationaryEnemy8();
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("First Hallway Trigger"))
        {
            GameControllerParent gc = GameObject.FindObjectOfType<GameControllerParent>
                ();

            gc.spawnMoveTowardsEnemy2();
            gc.spawnStationaryEnemy2();
            Destroy(firstHallWayTrigger);

        }
        if (collidedObject.name.Contains("First Room Trigger"))
        {
            GameControllerParent gc = GameObject.FindObjectOfType<GameControllerParent>
                ();

            gc.spawnMoveTowardsEnemy();
            gc.spawnStationaryEnemy();
            Destroy(firstRoomTrigger);

        }
        if (collidedObject.name.Contains("Second Hallway Trigger"))
        {
            GameControllerParent gc = GameObject.FindObjectOfType<GameControllerParent>
                ();

            gc.spawnMoveTowardsEnemy3();
            gc.spawnStationaryEnemy3();
            Destroy(secondHallWayTrigger);

        }
        if (collidedObject.name.Contains("Second Room Trigger"))
        {
            GameControllerParent gc = GameObject.FindObjectOfType<GameControllerParent>
                ();

            gc.spawnMoveTowardsEnemy4();
            gc.spawnStationaryEnemy4();
            Destroy(secondRoomTrigger);
        }
        if (collidedObject.name.Contains("Third Hallway Trigger"))
        {
            GameControllerParent gc = GameObject.FindObjectOfType<GameControllerParent>
                ();

            gc.spawnMoveTowardsEnemy5();
            gc.spawnStationaryEnemy5();
            Destroy(thirdHallwayTrigger);
        }
        if (collidedObject.name.Contains("Third Room Trigger"))
        {
            GameControllerParent gc = GameObject.FindObjectOfType<GameControllerParent>
                ();

            gc.spawnMoveTowardsEnemy6();
            gc.spawnStationaryEnemy6();
            Destroy(thirdRoomTrigger);
        }
        if (collidedObject.name.Contains("Fourth Hallway Trigger"))
        {
            GameControllerParent gc = GameObject.FindObjectOfType<GameControllerParent>
                ();

            gc.spawnMoveTowardsEnemy7();
            gc.spawnStationaryEnemy7();
            Destroy(fourthHallwayTrigger);
        }
    }
}