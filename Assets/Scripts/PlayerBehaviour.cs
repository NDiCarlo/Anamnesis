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

    public float fireRate;

    public float nextFire;

    public GameObject TriggerHallwayEnemies;

    public GameObject TriggerHallwayEnemies2;

    public GameObject TriggerHallwayEnemies3;

    public GameObject TriggerBoss;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        Shooting();
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
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
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
        if (collidedObject.name.Contains("Trigger Hallway Enemies"))
        {
            GameController gc = GameObject.FindObjectOfType<GameController>
                ();
            gc.spawnMoveTowardsEnemy5();
            gc.spawnStationaryEnemy5();
            Destroy(TriggerHallwayEnemies);
        }
        if (collidedObject.name.Contains("Trigger Hallway 2 Enemies"))
        {
            GameController gc = GameObject.FindObjectOfType<GameController>
                ();
            gc.spawnMoveTowardsEnemy6();
            gc.spawnStationaryEnemy6();
            Destroy(TriggerHallwayEnemies2);
        }
        if (collidedObject.name.Contains("Trigger Hallway 3 Enemies"))
        {
            GameController gc = GameObject.FindObjectOfType<GameController>
                ();
            gc.spawnMoveTowardsEnemy7();
            gc.spawnStationaryEnemy7();
            Destroy(TriggerHallwayEnemies3);
        }
        if (collidedObject.name.Contains("Boss Trigger"))
        {
            GameController gc = GameObject.FindObjectOfType<GameController>
                ();
            gc.spawnBossBehaviour();
            Destroy(TriggerBoss); ;
        }
    }
}