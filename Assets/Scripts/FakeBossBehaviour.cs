using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeBossBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;
        if (collidedObject.name.Contains("Player"))
        {
            Destroy(gameObject, 1);
        }
    }
}
