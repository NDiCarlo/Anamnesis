using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildFakeBehaviour : MonoBehaviour
{
    public GameObject realBoss;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            Destroy(gameObject);
            Instantiate(realBoss, transform.position, transform.rotation);
        }
    }
}