/*****************************************************************************
// File Name :         PlayerBehaviour.cs
// Author :            Nolan DiCarlo
// Creation Date :     September 15, 2021
//
// Brief Description : This is everything the player does in the Child Level, how the player
shoots, moves , changes weapons, and triggers for enemies to spawn, and collisions
of bullets or enemies 
*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public float arrowRate;

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

    public GameObject Spear;

    public bool enableSpear = false;

    public static bool isRead = false;

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

    public Image weaponBar;

    public Sprite weaponBarHighlighted;

    public Sprite weaponBarHighlighted2;

    public Sprite weaponBarHighlighted3;

    public GameObject arrowImage;

    public GameObject spearImage;

    public GameObject bulletImage;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Spear.SetActive(false);
        Bullet.SetActive(true);
        if(PlayerBehaviour.isRead == true)
        {
            arrowImage.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            enableBow = false;
            enableSpear = false;
            weaponBar.sprite = weaponBarHighlighted;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && PlayerBehaviour.isRead == true)
        {
            enableBow = true;
            enableSpear = false;
            weaponBar.sprite = weaponBarHighlighted2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && isRead == true)
        {
            enableBow = false;
            enableSpear = true;
            weaponBar.sprite = weaponBarHighlighted3;
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
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire && enableBow == true && enableSpear == false)
        {
            nextFire = Time.time + arrowRate;
            Instantiate(Arrow, transform.position, transform.rotation);
            Bullet.SetActive(false);
            Spear.SetActive(false);
            Arrow.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire && enableSpear == true && enableBow == false)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Spear, transform.position, transform.rotation);
            Bullet.SetActive(false);
            Spear.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("Door") && (SceneManager.GetActiveScene().name == "ChildLevelOPENScene"))
        {
            PlayerBehaviour.numberofLevels++;
            SceneManager.LoadScene("DialogueScene4");
        }
        else if (collidedObject.name.Contains("Door"))
        {
            SceneManager.LoadScene("DialogueScene3");
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
            Time.timeScale = 0;
            health1.enabled = false;
            health2.enabled = false;
            health3.enabled = false;
            health4.enabled = false;
            health5.enabled = false;
            weaponBar.enabled = false;
            bulletImage.SetActive(false);
            arrowImage.SetActive(false);

        }
        if (collidedObject.name.Contains("2nd Open Room Dialogue"))
        {
            secondroomDialogue.SetActive(true);
            Destroy(RedBox2);
            Time.timeScale = 0;
            health1.enabled = false;
            health2.enabled = false;
            health3.enabled = false;
            health4.enabled = false;
            health5.enabled = false;
            weaponBar.enabled = false;
            bulletImage.SetActive(false);
            arrowImage.SetActive(false);
            spearImage.SetActive(false);
        }
        if (collidedObject.name.Contains("3rd Open Room Dialogue"))
        {
            thirdroomDialogue.SetActive(true);
            Destroy(RedBox3);
            Time.timeScale = 0;
            health1.enabled = false;
            health2.enabled = false;
            health3.enabled = false;
            health4.enabled = false;
            health5.enabled = false;
            weaponBar.enabled = false;
            bulletImage.SetActive(false);
            arrowImage.SetActive(false);
            spearImage.SetActive(false);
        }
        if (collidedObject.name.Contains("Before Boss Dialogue"))
        {
            beforeBossDialogue.SetActive(true);
            Destroy(RedBox4);
            Destroy(RedBox5);
            Time.timeScale = 0;
            health1.enabled = false;
            health2.enabled = false;
            health3.enabled = false;
            health4.enabled = false;
            health5.enabled = false;
            weaponBar.enabled = false;
            bulletImage.SetActive(false);
            arrowImage.SetActive(false);
            spearImage.SetActive(false);
        }
        if (collidedObject.name.Contains("After Boss Open Dialogue"))
        {
            afterBossDialogue.SetActive(true);
            Destroy(RedBox6);
            Time.timeScale = 0;
            health1.enabled = false;
            health2.enabled = false;
            health3.enabled = false;
            health4.enabled = false;
            health5.enabled = false;
            weaponBar.enabled = false;
            bulletImage.SetActive(false);
            arrowImage.SetActive(false);
            spearImage.SetActive(false);
        }
        if (collidedObject.name.Contains("After Boss Closed Dialogue"))
        {
            afterBossclosedDialogue.SetActive(true);
            Destroy(RedBox7);
            Time.timeScale = 0;
            health1.enabled = false;
            health2.enabled = false;
            health3.enabled = false;
            health4.enabled = false;
            health5.enabled = false;
            weaponBar.enabled = false;
            bulletImage.SetActive(false);
            arrowImage.SetActive(false);
            spearImage.SetActive(false);
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
        spearImage.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("MoveTowardEnemyChildLevel"))
        {
            health--;

            RegenHealth = false;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("StationaryEnemyBulletChildLevel"))
        {
            health--;

            RegenHealth = false;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("StationaryEnemyChildLevel"))
        {
            health--;

            RegenHealth = false;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("ChildBoss"))
        {
            health--;

            RegenHealth = false;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("ChildScythe"))
        {
            health--;

            RegenHealth = false;

            timestamp = Time.time;

            if (health <= 0)
            {
                deathPanel.SetActive(true);
            }
        }
        if (collidedObject.name.Contains("AoE Damage"))
        {
            health--;

            RegenHealth = false;

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