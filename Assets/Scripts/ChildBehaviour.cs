using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildBehaviour : MonoBehaviour
{
    private bool isMoving = true;
    private Transform player = GameObject.Find("Player").GetComponent<Transform>();
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BossBehaviour());
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            Vector3 newPos = Vector3.MoveTowards(transform.position,
                                               player.position,
                                               Time.deltaTime * speed);
            transform.position = newPos;
        }
    }

    public void BossMovement()
    {

    }

    private IEnumerator BossBehaviour()
    {
        StartCoroutine(BossBehaviour());
    }
}