using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 5;

    public GameObject BossPanel;

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

    public GameObject EnchantWeaponPanel;

    public GameObject weaponSpear;

    public bool enableSpear = false;

    public GameObject firstDiagloguePanel;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Bullet.gameObject.SetActive(true);
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
        if (Input.GetKeyDown(KeyCode.Alpha2) && enableSpear == true)
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

        if (collidedObject.name.Contains("Door"))
        {
            BossPanel.gameObject.SetActive(true);
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
        if (collidedObject.name.Contains("Enchant Weapon Paper"))
        {
            EnchantWeaponPanel.gameObject.SetActive(true);
        }
        if (collidedObject.name.Contains("1st Open Room Dialogue"))
        {
            firstDiagloguePanel.gameObject.SetActive(true);
        }
    }
    public void EnchantSpear()
    {
        enableSpear = true;
        EnchantWeaponPanel.gameObject.SetActive(false);
    }
}