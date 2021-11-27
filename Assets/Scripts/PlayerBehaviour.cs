using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 5;

    public GameObject Panel;

    public GameObject TriggerFirstRoomEnemies;

    public GameObject TriggerSecondRoomEnemies;

    public GameObject TriggerThirdRoomEnemies;

    public int health;

    public GameObject Bullet;

    public float fireRate;

    public float nextFire;

    public GameObject TriggerHallwayEnemies;

    public GameObject TriggerHallwayEnemies2;

    public GameObject TriggerHallwayEnemies3;

    public GameObject TriggerBoss;

    public GameObject EnchantWeaponPanel;

    public GameObject Arrow;

    public bool enableBow = false;

    public GameObject firstDiagloguePanel;

    public GameObject secondDialoguePanel;

    public GameObject dialoguebeforebossPanel;

    public GameObject dialogueAfterbossPanel;

    public GameObject dialogueAfterbossClosedPanel;

    public GameObject deathPanel;

    public int maxHealth;

    public float timestamp = 0.0f;

    public GameObject Bow;

    public static bool isRead = false;

    public GameObject door;

    public GameObject afterBossDialogue;

    public GameObject RedBox1;

    public GameObject RedBox2;

    public GameObject RedBox3;

    public GameObject RedBox4;

    public GameObject RedBox5;

    public GameObject RedBox6;

    public Image health1;

    public Image health2;

    public Image health3;

    public Image health4;

    public Image health5;

    public Sprite halfHealth;

    public Sprite emptyHealth;

    public Sprite fullHealth;

    public bool RegenHealth;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Bullet.gameObject.SetActive(true);
        Arrow.SetActive(false);
        Bow.SetActive(false);
        RegenHealth = false;
    }


    // Update is called once per frame
    void Update()
    {
        Attack();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            enableBow = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && isRead == true)
        {
            enableBow = true;
        }

        HealthSprites();
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
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire && enableBow == false)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Bullet, transform.position, transform.rotation);
            Bullet.SetActive(true);
            Arrow.SetActive(false);
            Bow.SetActive(false);
        }
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire && enableBow == true)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Arrow, transform.position, transform.rotation);
            Instantiate(Bow, transform.position, transform.rotation);
            Arrow.SetActive(true);
            Bow.SetActive(true);
            Bullet.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("Door"))
        {
            Panel.gameObject.SetActive(true);
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
            Destroy(RedBox3);
        }
        if (collidedObject.name.Contains("1st Open Room Dialogue"))
        {
            firstDiagloguePanel.gameObject.SetActive(true);
            Destroy(RedBox1);
        }
        if (collidedObject.name.Contains("2nd Open Room Dialogue"))
        {
            secondDialoguePanel.gameObject.SetActive(true);
            Destroy(RedBox2);
        }
        if (collidedObject.name.Contains("Before Boss Dialogue"))
        {
            dialoguebeforebossPanel.gameObject.SetActive(true);
            Destroy(RedBox4);
        }
        if (collidedObject.name.Contains("After Boss Open Dialogue"))
        {
            dialogueAfterbossPanel.gameObject.SetActive(true);
            Destroy(RedBox5);
        }
        if (collidedObject.name.Contains("After Boss Closed Dialogue"))
        {
            dialogueAfterbossClosedPanel.gameObject.SetActive(true);
            Destroy(RedBox6);
        }
    }
    public void EnchantBow()
    {
        enableBow = true;
        isRead = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("MoveTowardEnemy"))
        {
            health--;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("StationaryEnemyBullet"))
        {
            health--;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        else if (collidedObject.name.Contains("StationaryEnemy"))
        {
            health--;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("LoverLevelBoss"))
        {
            health--;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("BossBulletLoverLevel"))
        {
            health -= 2;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("AoE Damage"))
        {
            health -= 2;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
    }
    public void HealthSprites()
    {
        if (health == 10)
        {
            RegenHealth = false;
            health5.sprite = fullHealth;
        }
            if (health == 9 && RegenHealth == false)
        {
            health5.sprite = halfHealth;
        }
        if (health == 8 && RegenHealth == false)
        {
            health5.sprite = emptyHealth;
        }
        if (health == 7 && RegenHealth == false)
        {
            health4.sprite = halfHealth;
        }
        if (health == 6 && RegenHealth == false)
        {
            health4.sprite = emptyHealth;
        }
        if (health == 5 && RegenHealth == false)
        {
            health3.sprite = halfHealth;
        }
        if (health == 4 && RegenHealth == false)
        {
            health3.sprite = emptyHealth;
        }
        if (health == 3 && RegenHealth == false)
        {
            health2.sprite = halfHealth;
        }
        if (health == 2 && RegenHealth == false)
        {
            health2.sprite = emptyHealth;
        }
        if (health == 1 && RegenHealth == false)
        {
            health1.sprite = halfHealth;
        }

        //Helps Sprites RegenHealth
        if (health == 2 && RegenHealth == true)
        {
            health1.sprite = fullHealth;
        }
        if (health == 3 && RegenHealth == true)
        {
            health2.sprite = halfHealth;
        }
        if (health == 4 && RegenHealth == true)
        {
            health2.sprite = fullHealth;
        }
        if (health == 5 && RegenHealth == true)
        {
            health3.sprite = halfHealth;
        }
        if (health == 6 && RegenHealth == true)
        {
            health3.sprite = fullHealth;
        }
        if (health == 7 && RegenHealth == true)
        {
            health4.sprite = halfHealth;
        }
        if (health == 8 && RegenHealth == true)
        {
            health4.sprite = fullHealth;
        }
        if (health == 9 && RegenHealth == true)
        {
            health5.sprite = halfHealth;
        }

        if (health == 0)
        {
            health1.enabled = false;
            health2.enabled = false;
            health3.enabled = false;
            health4.enabled = false;
            health5.enabled = false;

        }
    }
}