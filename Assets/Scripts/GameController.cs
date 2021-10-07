using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject moveTowardsEnemy;

    public GameObject stationaryEnemy;

    private int enemiesPerWave = 2;

    private int enemiesPerWave2 = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void spawnMoveTowardsEnemy()
    {
        for (int i = 0; i < enemiesPerWave; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-62f, -26),
                                            Random.Range(54, 43));
        }
    }
    public void spawnStationaryEnemy()
    {
        for (int i = 0; i < enemiesPerWave2; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-64f, -25),
                                            Random.Range(55.46499f, 55.46499f));
        }
    }
}
