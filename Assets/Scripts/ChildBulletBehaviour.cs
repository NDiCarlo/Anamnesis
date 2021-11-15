using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildBulletBehaviour : MonoBehaviour
{
    public float lifeTime = 2f;
    public float speed = 5f;
    [Tooltip("The degrees of rotation: this just affects how fast it rotates.")]
    public float degrees = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speed;
        transform.rotation = Quaternion.Euler(Vector3.forward * degrees);
    }
}