using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildBehaviour : MonoBehaviour
{
    private bool isMoving = true;
    private Transform player;
    public float speed;
    public SpriteRenderer childLevelBoss;
    public float range = 10f;
    public GameObject DamageAOE;
    public GameObject projectile;
    public float health = 15f;
    private Rigidbody2D rb;
    public Sprite bossBulletLeft;
    public Sprite bossBulletRight;
    public Sprite bossLeft;
    public Sprite bossRight;
    public Sprite bossSummoningLeft;
    public Sprite bossSummoningRight;


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

            if (health <= 0)
            {
                PlayerBehaviourChildLevel pb = GameObject.FindObjectOfType<PlayerBehaviourChildLevel>
                    ();

                pb.health = 50;

                pb.door.SetActive(true);

                pb.afterBossDialogue.SetActive(true);

                Destroy(gameObject);
            }
        }
    }

    public void BossMovement()
    {
        if (isMoving)
        {
            if(childLevelBoss.transform.position.x > player.transform.position.x)
            {
                childLevelBoss.sprite = bossLeft;

                Vector3 newPos = Vector3.MoveTowards(transform.position,
                                               player.position,
                                               Time.deltaTime * speed);
                transform.position = newPos;
            }
            if (childLevelBoss.transform.position.x < player.transform.position.x)
            {
                childLevelBoss.sprite = bossRight;

                Vector3 newPos = Vector3.MoveTowards(transform.position,
                                               player.position,
                                               Time.deltaTime * speed);
                transform.position = newPos;
            }
        }
    }

    private IEnumerator BossBehaviour()
    {
        yield return new WaitForSeconds(3f);

        childLevelBoss.color = Color.red;

        yield return new WaitForSeconds(.10f);

        childLevelBoss.color = Color.white;

        yield return new WaitForSeconds(.10f);

        childLevelBoss.color = Color.red;

        yield return new WaitForSeconds(.5f);

        childLevelBoss.color = Color.white;

        yield return new WaitForSeconds(.5f);

        isMoving = false;

        attack();

        yield return new WaitForSeconds(.5f);

        if (childLevelBoss.transform.position.x > player.transform.position.x)
        {
            childLevelBoss.sprite = bossLeft;
        }
        if (childLevelBoss.transform.position.x < player.transform.position.x)
        {
            childLevelBoss.sprite = bossRight;
        }

        childLevelBoss.color = Color.white;

        yield return new WaitForSeconds(.2f);

        DamageAOE.SetActive(false);

        yield return new WaitForSeconds(1.5f);

        isMoving = true;

        yield return new WaitForSeconds(1f);

        StartCoroutine(BossBehaviour());
    }

    public void attack()
    {
        if (Vector2.Distance(transform.position, player.position) <= range)
        {
            if (childLevelBoss.transform.position.x > player.transform.position.x)
            {
                DamageAOE.SetActive(true);
                childLevelBoss.sprite = bossSummoningLeft;
            }
            if (childLevelBoss.transform.position.x < player.transform.position.x)
            {
                DamageAOE.SetActive(true);
                childLevelBoss.sprite = bossSummoningRight;
            }
        }
        if(Vector2.Distance(transform.position, player.position) >= range)
        {
            if (childLevelBoss.transform.position.x > player.transform.position.x)
            {
                DamageAOE.SetActive(false);
                Instantiate(projectile, transform.position, transform.rotation);
                childLevelBoss.sprite = bossBulletLeft;
            }
            if (childLevelBoss.transform.position.x < player.transform.position.x)
            {
                DamageAOE.SetActive(false);
                Instantiate(projectile, transform.position, transform.rotation);
                childLevelBoss.sprite = bossBulletRight;
            }
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
            health--;
            StartCoroutine(hitBoss());
        }
        if (collidedObject.name.Contains("Weapon Spear"))
        {
            health--;
            StartCoroutine(hitBoss());
        }
    }

    private IEnumerator hitBoss()
    {
        childLevelBoss.color = Color.red;

        yield return new WaitForSeconds(.05f);

        childLevelBoss.color = Color.white;
    }
}