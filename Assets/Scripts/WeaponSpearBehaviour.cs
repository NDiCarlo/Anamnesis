using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpearBehaviour : MonoBehaviour
{
    Vector3 mousePosition;

    Vector3 mouseRotation;

    private Vector3 direction;

    public float Lifetime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Lifetime);
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;
        mouseRotation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseRotation.z = 0f;
        direction = (mousePosition - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }
    void Rotation()
    {
        Vector3 mousPos = Input.mousePosition;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousPos);

        Vector2 delta = transform.position - worldPos;


        float angle = Mathf.Atan2(delta.y, delta.x) * Mathf.Rad2Deg;
        //print("Screen : " + mousPos + " World : " + worldPos);

        transform.rotation = Quaternion.Euler(0, 0, angle + 90);
    }
}