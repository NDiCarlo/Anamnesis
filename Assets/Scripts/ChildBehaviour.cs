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
            Vector3 newPos = Vector3.MoveTowards(transform.position,
                                               player.position,
                                               Time.deltaTime * speed);
            transform.position = newPos;
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
            DamageAOE.SetActive(true);
        }
        if(Vector2.Distance(transform.position, player.position) >= range)
        {
            DamageAOE.SetActive(false);
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.name.Contains("Bullet"))
        {
            health--;
        }
        if (collidedObject.name.Contains("Arrow"))
        {
            health--;
        }
        if (collidedObject.name.Contains("Weapon Spear"))
        {
            health--;
        }
    }
}