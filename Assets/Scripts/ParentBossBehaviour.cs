using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParentBossBehaviour : MonoBehaviour
{
    private Transform player;
    public float speed;
    public SpriteRenderer parentLevelBoss;
    public float range = 10f;
    public GameObject telegraph;
    public GameObject attack;
    public float health = 50;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BossBehaviour());
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        if (health <= 0)
        {
            PlayerBehaviourParent pb = GameObject.FindObjectOfType<PlayerBehaviourParent>
                ();

            pb.health = 50;

            pb.door.SetActive(true);

            pb.afterBossDialogue.SetActive(true);

            Destroy(gameObject);
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
        parentLevelBoss.color = Color.red;

        yield return new WaitForSeconds(.1f);

        parentLevelBoss.color = Color.white;
    }
    public IEnumerator BossBehaviour()
    {
        yield return new WaitForSeconds(3f);

        parentLevelBoss.color = Color.red;

        yield return new WaitForSeconds(.10f);

        parentLevelBoss.color = Color.white;

        yield return new WaitForSeconds(.10f);

        parentLevelBoss.color = Color.red;

        yield return new WaitForSeconds(.5f);

        parentLevelBoss.color = Color.white;

        yield return new WaitForSeconds(.5f);

        Vector3 memorizePos = player.position;

        Instantiate(telegraph, memorizePos, transform.rotation);

        yield return new WaitForSeconds(.3f);

        Instantiate(attack, memorizePos, transform.rotation);

        StartCoroutine(BossBehaviour());
    }

    // Call this function when the music box is activated
    void musicBox()
    {
        StopCoroutine(BossBehaviour());

        StartCoroutine(MusicBoxBehaviour());
    }

    private IEnumerator MusicBoxBehaviour()
    {
        parentLevelBoss.color = Color.red;

        yield return new WaitForSeconds(2.10f);

        parentLevelBoss.color = Color.white;

        yield return new WaitForSeconds(.10f);

        parentLevelBoss.color = Color.red;

        yield return new WaitForSeconds(.5f);

        parentLevelBoss.color = Color.white;

        StartCoroutine(BossBehaviour());
    }
}