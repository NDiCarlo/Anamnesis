/*****************************************************************************
// File Name :         LoverLevelBossBehaviour.cs
// Author :            Nolan DiCarlo
// Creation Date :     October 25, 2021
//
// Brief Description: This is the Behaviour of the Lover Level Boss
This is how the boss moves and does its attack

*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoverLevelBossBehaviour : MonoBehaviour
{
    private Transform player;

    public int health = 50;

    private Rigidbody2D rb;

    private bool isMoving = true;

    public float range;

    public GameObject DamageAOE;

    public GameObject BossBullet;

    public float fireRate;

    public float nextFire;

    public SpriteRenderer loverLevelBoss;

    public Sprite loverBossSummoning;

    public Sprite bossBulletspriteLeft;

    public Sprite bossBulletspriteRight;

    public Sprite bossIdleSprite;

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerGO = GameObject.Find("Player");
        player = playerGO.transform;
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(BossBehaviour());
    }

    // Update is called once per frame
    void Update()
    {
        BossMovement();
        if (health <= 0)
        {
            Destroy(gameObject);

            PlayerBehaviour pb = GameObject.FindObjectOfType<PlayerBehaviour>
                    ();

            pb.health = 50;

            pb.door.SetActive(true);

            pb.afterBossDialogue.SetActive(true);
        }
    }
    public void attack()
    {
        if (Vector2.Distance(transform.position, player.position) <= range)
        {
            DamageAOE.SetActive(true);
            loverLevelBoss.sprite = loverBossSummoning;
        }
        if (Vector2.Distance(transform.position, player.position) >= range) 
        {
            if(loverLevelBoss.transform.position.x > player.transform.position.x)
            {
                DamageAOE.SetActive(false);
                nextFire = Time.time + fireRate;
                Instantiate(BossBullet, transform.position, transform.rotation);
                loverLevelBoss.sprite = bossBulletspriteLeft;
            }
            if (loverLevelBoss.transform.position.x < player.transform.position.x)
            {
                DamageAOE.SetActive(false);
                nextFire = Time.time + fireRate;
                Instantiate(BossBullet, transform.position, transform.rotation);
                loverLevelBoss.sprite = bossBulletspriteRight;
            }
        }
    }
    public void BossMovement()
    {
        if (isMoving == true)
        {
            Vector3 newPos = Vector3.MoveTowards(transform.position,
                                               player.position,
                                               Time.deltaTime * speed);
            transform.position = newPos;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("Bullet"))
        {
            health--;
            StartCoroutine(hitBoss());

        }
        if (collidedObject.name.Contains("Arrow"))
        {
            health -= 2;
            StartCoroutine(hitBoss());
        }
    }
    private IEnumerator hitBoss()
    {
        loverLevelBoss.color = Color.red;

        yield return new WaitForSeconds(.15f);

        loverLevelBoss.color = Color.white;
    }

    public float speed;
    private IEnumerator BossBehaviour()
    {
        yield return new WaitForSeconds(3f);

        loverLevelBoss.color = Color.red;

        yield return new WaitForSeconds(.10f);

        loverLevelBoss.color = Color.white;

        yield return new WaitForSeconds(.10f);

        loverLevelBoss.color = Color.red;

        yield return new WaitForSeconds(.5f);

        loverLevelBoss.color = Color.white;

        yield return new WaitForSeconds(.5f);

        isMoving = false;

        attack();

        yield return new WaitForSeconds(.5f);

        loverLevelBoss.sprite = bossIdleSprite;

        loverLevelBoss.color = Color.white;

        yield return new WaitForSeconds(.2f);

        DamageAOE.SetActive(false);

        yield return new WaitForSeconds(1.5f);

        isMoving = true;

        yield return new WaitForSeconds(1f);

        StartCoroutine(BossBehaviour());
    }
}