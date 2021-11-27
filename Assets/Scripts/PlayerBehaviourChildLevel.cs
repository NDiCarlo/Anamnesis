using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviourChildLevel : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;

    public GameObject FirstRoomTrigger;

    public GameObject RoomTriggerLeft;

    public GameObject RoomTriggerRight;

    public GameObject LeftHallwayTrigger;

    public GameObject RightHallwayTrigger;

    public int health;

    public GameObject Arrow;

    public bool enableBow;

    public float fireRate;

    public float nextFire;

    public GameObject Bullet;

    public GameObject firstroomDialogue;

    public GameObject secondroomDialogue;

    public GameObject thirdroomDialogue;

    public GameObject beforeBossDialogue;

    public GameObject afterBossDialogue;

    public GameObject afterBossclosedDialogue;

    public GameObject deathPanel;

    public int maxHealth;

    public float timestamp = 0.0f;

    public GameObject Bow;

    public GameObject Spear;

    public bool enableSpear = false;

    public static bool isRead = false;

    public GameObject Panel;

    public GameObject door;

    public GameObject afterbossdialogue;

    public GameObject TriggerBoss;

    public GameObject InstantiateBossTrigger;

    public GameObject InstantiateBossTrigger2;

    public GameObject RedBox1;

    public GameObject RedBox2;

    public GameObject RedBox3;

    public GameObject RedBox4;

    public GameObject RedBox5;

    public GameObject RedBox6;

    public GameObject RedBox7;

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
        Bow.SetActive(true);
        Spear.SetActive(false);
        Bullet.SetActive(true);
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
        if (Input.GetKeyDown(KeyCode.Alpha3) && isRead == true)
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collidedObject = collision.gameObject;
        if (collidedObject.name.Contains("Door"))
        {
            Panel.gameObject.SetActive(true);
        }
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
        if (collidedObject.name.Contains("1st Open Room Dialogue"))
        {
            firstroomDialogue.SetActive(true);
            Destroy(RedBox1);

        }
        if (collidedObject.name.Contains("2nd Open Room Dialogue"))
        {
            secondroomDialogue.SetActive(true);
            Destroy(RedBox2);
        }
        if (collidedObject.name.Contains("3rd Open Room Dialogue"))
        {
            thirdroomDialogue.SetActive(true);
            Destroy(RedBox3);
        }
        if (collidedObject.name.Contains("Before Boss Dialogue"))
        {
            beforeBossDialogue.SetActive(true);
            Destroy(RedBox4);
            Destroy(RedBox5);
        }
        if (collidedObject.name.Contains("After Boss Open Dialogue"))
        {
            afterBossDialogue.SetActive(true);
            Destroy(RedBox6);
        }
        if (collidedObject.name.Contains("After Boss Closed Dialogue"))
        {
            afterBossclosedDialogue.SetActive(true);
            Destroy(RedBox7);
        }
        if (collidedObject.name.Contains("InstantiateBossTrigger"))
        {
            GameControllerChildLevel gc = GameObject.FindObjectOfType<GameControllerChildLevel>
                ();
            gc.spawnBossBehaviour();
            Destroy(TriggerBoss);
            Destroy(InstantiateBossTrigger);
            Destroy(InstantiateBossTrigger2);

        }
    }

    public void EnchantSpear()
    {
        Spear.SetActive(true);
        isRead = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("MoveTowardEnemyChildLevel"))
        {
            health--;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("StationaryEnemyBulletChildLevel"))
        {
            health--;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("StationaryEnemyChildLevel"))
        {
            health--;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("ChildBoss"))
        {
            health--;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("ChildScythe"))
        {
            health--;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("AoE Damage"))
        {
            health--;

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