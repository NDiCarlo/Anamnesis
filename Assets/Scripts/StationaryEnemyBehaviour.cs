using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryEnemyBehaviour : MonoBehaviour
{
    public float fireRate;
    public float nextFire; 

    public GameObject bullet;

    public Transform firePoint;

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        checktimetoFire();
    }
    void checktimetoFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
