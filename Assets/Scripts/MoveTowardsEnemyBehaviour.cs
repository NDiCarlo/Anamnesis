using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsEnemyBehaviour : MonoBehaviour
{
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        GameObject playerGO = GameObject.Find("Player");
        player = playerGO.transform;
    }

    // Update is called once per frame
    void Update()
    {
        enemyMovement();
    }

    public float speed = 0.5f;
    void enemyMovement()
    {
        Vector3 newPos = Vector3.MoveTowards(transform.position,
                                               player.position,
                                               Time.deltaTime * speed);
        transform.position = newPos;
    }
}
