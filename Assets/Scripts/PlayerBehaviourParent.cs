using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public int health;

    public GameObject secondRoomTrigger;

    public GameObject thirdHallwayTrigger;

    public GameObject thirdRoomTrigger;

    public GameObject fourthHallwayTrigger;

    public GameObject firstroomDialogue;

    public GameObject beforebossDialogue;

    public GameObject afterbossDialogue;

    public GameObject deathPanel;

    public int maxHealth;

    public float timestamp = 0.0f;

    public GameObject Spear;

    public GameObject Bow;

    public GameObject Arrow;

    public bool enableBow;

    public GameObject Panel;

    public GameObject firstOpenRedBox;

    public GameObject beforeBossRedBox;

    public GameObject door;

    public GameObject afterBossDialogue;

    public GameObject TriggerBoss;

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
        enableSpear = false;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            enableBow = false;
            enableSpear = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && PlayerBehaviour.isRead == true)
        {
            enableBow = true;
            enableSpear = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && PlayerBehaviourChildLevel.isRead == true)
        {
            enableBow = false;
            enableSpear = true;
        }

        HealthSprites();
    }
    void FixedUpdate()
    {
        Movement();
    }
    void Attack()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire && enableBow == false && enableSpear == false)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Bullet, transform.position, transform.rotation);
            Bullet.gameObject.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire && enableBow == true)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Arrow, transform.position, transform.rotation);
            Instantiate(Bow, transform.position, transform.rotation);
            Bullet.SetActive(false);
            Spear.SetActive(false);
            Bow.SetActive(true);
            Arrow.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire && enableSpear == true)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Spear, transform.position, transform.rotation);
            Bullet.SetActive(false);
            Arrow.SetActive(false);
            Bow.SetActive(false);
            Spear.SetActive(true);
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

        if (collidedObject.name.Contains("Door"))
        {
            Panel.gameObject.SetActive(true);
        }
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
        if (collidedObject.name.Contains("1st Open Room Dialogue"))
        {
            firstroomDialogue.gameObject.SetActive(true);
            Destroy(firstOpenRedBox);
        }
        if (collidedObject.name.Contains("Before Boss Dialogue"))
        {
            beforebossDialogue.gameObject.SetActive(true);
            Destroy(beforeBossRedBox);
        }
        if (collidedObject.name.Contains("After Boss Closed Dialogue"))
        {
            afterbossDialogue.gameObject.SetActive(true);
        }
        if (collidedObject.name.Contains("After Boss Open Dialogue"))
        {
            afterbossDialogue.gameObject.SetActive(true);
        }
        if (collidedObject.name.Contains("InstantiateBossTrigger"))
        {
            GameControllerParent gc = GameObject.FindObjectOfType<GameControllerParent>
                ();
            gc.spawnBossBehaviour();
            Destroy(TriggerBoss); ;
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("MoveTowardsEnemyParent"))
        {
            health--;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("StationaryEnemyParent"))
        {
            health--;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("StationaryEnemyBulletParentLevel"))
        {
            health--;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("ParentBoss"))
        {
            health--;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("ParentAttack"))
        {
            health -=2;

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
