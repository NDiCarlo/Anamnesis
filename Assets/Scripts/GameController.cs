using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject moveTowardsEnemy;

    public GameObject stationaryEnemy;

    private int enemiesPerWave = 4;

    private int enemiesPerWave2 = 2;

    public GameObject FirstRoomBarricade;

    public GameObject SecondRoomBarricade;

    public GameObject ThirdRoomBarricade;

    public int numberofEnemies = 18;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (numberofEnemies == 12)
        {
            Destroy(FirstRoomBarricade);
        }
        if (numberofEnemies == 6)
        {
            Destroy(SecondRoomBarricade);
        }
        if (numberofEnemies == 0)
        {
            Destroy(ThirdRoomBarricade);
        }
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
    public void spawnMoveTowardsEnemy2()
    {
        for (int i = 0; i < enemiesPerWave; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(13f, 50),
                                            Random.Range(67, 52));
        }
    }
    public void spawnStationaryEnemy2()
    {
        for (int i = 0; i < enemiesPerWave2; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(21f, 40),
                                            Random.Range(67.5f, 67.5f));
        }
    }
    public void spawnMoveTowardsEnemy3()
    {
        for (int i = 0; i < enemiesPerWave; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(81f, 130f),
                                            Random.Range(55f, 42f));
        }
    }
    public void spawnStationaryEnemy3()
    {
        for (int i = 0; i < enemiesPerWave2; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(95f, 116f),
                                            Random.Range(55f, 55f));
        }
    }
}
