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
        if(health <= 0)
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
            
        }
        if (Vector2.Distance(transform.position, player.position) >= range)
        {
            DamageAOE.SetActive(false);
            nextFire = Time.time + fireRate;
            Instantiate(BossBullet, transform.position, transform.rotation);
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

        loverLevelBoss.color = Color.white;

        yield return new WaitForSeconds(.2f);

        DamageAOE.SetActive(false);

        yield return new WaitForSeconds(1.5f);

        isMoving = true;

        yield return new WaitForSeconds(1f);

        StartCoroutine(BossBehaviour());
    }
}