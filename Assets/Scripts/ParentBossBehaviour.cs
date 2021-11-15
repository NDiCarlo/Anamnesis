using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentBossBehaviour : MonoBehaviour
{
    private Transform player = GameObject.Find("Player").GetComponent<Transform>();
    public float speed;
    public SpriteRenderer parentLevelBoss;
    public float range = 10f;
    public GameObject damageAOE;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BossBehaviour());
    }

    // Update is called once per frame
    void Update()
    {
        
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

        attack();

        StartCoroutine(BossBehaviour());
    }

    public void attack()
    {
        if (Vector2.Distance(player.position, transform.position) >= range)
        {
            
        }
    }
}