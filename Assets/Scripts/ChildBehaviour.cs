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
    public GameObject damageAOE;
    public GameObject projectile;
    public float health = 15f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        StartCoroutine(BossBehaviour());
    }

    // Update is called once per frame
    void Update()
    {
        BossMovement();
        if (health <= 0)
        {
            Destroy(gameObject);
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

        damageAOE.SetActive(false);

        yield return new WaitForSeconds(1.5f);

        isMoving = true;

        yield return new WaitForSeconds(1f);

        StartCoroutine(BossBehaviour());
    }

    public void attack()
    {
        if (Vector2.Distance(transform.position, player.position) <= range)
        {
            damageAOE.SetActive(true);
        }
        else
        {
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {

        }
    }
}