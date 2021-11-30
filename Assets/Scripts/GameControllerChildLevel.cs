using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerChildLevel : MonoBehaviour
{
    private int enemiesPerWave = 4;

    private int enemiesPerWave2 = 2;

    private int enemiesPerWave3 = 2;

    private int enemiesPerWave4 = 1;

    public GameObject moveTowardsEnemy;

    public GameObject stationaryEnemy;

    public GameObject firstroombarricadeLeft;

    public GameObject firstroombarricadeRight;

    public GameObject secondbossbarricadeRight;

    public GameObject secondbossbarricadeLeft;

    public GameObject firstbossbarricadeRight;

    public GameObject firstbossbarricadeLeft;

    public float numberofEnemies = 45;

    public GameObject player;

    public GameObject mainMenu;
    public GameObject restart;
    public GameObject resume;

    public GameObject ChildBoss;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (numberofEnemies == 39)
        {
            Destroy(firstroombarricadeLeft);
            Destroy(firstroombarricadeRight);
        }
        if (numberofEnemies == 24)
        {
            Destroy(secondbossbarricadeLeft);
            Destroy(secondbossbarricadeRight);
        }
        if (numberofEnemies == 9)
        {
            Destroy(firstbossbarricadeLeft);
            Destroy(firstbossbarricadeRight);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
            mainMenu.SetActive(true);
            restart.SetActive(true);
            resume.SetActive(true);

            player.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void spawnMoveTowardsEnemy()
    {
        for (int i = 0; i < enemiesPerWave; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(23f, 46f),
                                            Random.Range(20f, 12f));

            MoveTowardsEnemyChildLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyChildLevel>
                ();

            mt.health = 2;
        }
    }
    public void spawnStationaryEnemy()
    {
        for (int i = 0; i < enemiesPerWave2; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(24f, 43f),
                                            Random.Range(22.93f, 22.93f));

            StationaryEnemyChildLevel se = GameObject.FindObjectOfType<StationaryEnemyChildLevel>
                ();

            se.health = 1;
        }
    }
    public void spawnMoveTowardsEnemy2()
    {
        for (int i = 0; i < enemiesPerWave; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-31f, -9f),
                                            Random.Range(62f, 50f));

            MoveTowardsEnemyChildLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyChildLevel>
                ();

            mt.health = 4;
        }
    }
    public void spawnStationaryEnemy2()
    {
        for (int i = 0; i < enemiesPerWave2; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-25f, -12.42f),
                                            Random.Range(62.67f, 62.67f));

            StationaryEnemyChildLevel se = GameObject.FindObjectOfType<StationaryEnemyChildLevel>
                ();

            se.health = 2;
        }
    }
    public void spawnMoveTowardsEnemy3()
    {
        for (int i = 0; i < enemiesPerWave; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(77.96f, 102.79f),
                                            Random.Range(61.56f, 50.88f));

            MoveTowardsEnemyChildLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyChildLevel>
                ();

            mt.health = 4;
        }
    }
    public void spawnStationaryEnemy3()
    {
        for (int i = 0; i < enemiesPerWave2; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(81.96f, 99.4f),
                                            Random.Range(64.23f, 64.23f));

            StationaryEnemyChildLevel se = GameObject.FindObjectOfType<StationaryEnemyChildLevel>
                ();

            se.health = 2;
        }
    }

    public void spawnMoveTowardsEnemy4()
    {
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-1.7f, -0.1f),
                                            Random.Range(26.83f, 28.29f));

            MoveTowardsEnemyChildLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyChildLevel>
                ();

            mt.health = 2;
        }
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-6.8f, -2.1f),
                                            Random.Range(37.4f, 34.7f));

            MoveTowardsEnemyChildLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyChildLevel>
                ();

            mt.health = 2;
        }
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-15.1f, -11f),
                                            Random.Range(42.4f, 40.7f));

            MoveTowardsEnemyChildLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyChildLevel>
                ();

            mt.health = 2;
        }
    }
    public void spawnStationaryEnemy4()
    {
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(10.1f, 28.7f);

            StationaryEnemyChildLevel se = GameObject.FindObjectOfType<StationaryEnemyChildLevel>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(-0.71f, 37.06f);

            StationaryEnemyChildLevel se = GameObject.FindObjectOfType<StationaryEnemyChildLevel>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(-11.5f, 44.4f);

            StationaryEnemyChildLevel se = GameObject.FindObjectOfType<StationaryEnemyChildLevel>
                ();

            se.health = 1;
        }
    }
    public void spawnMoveTowardsEnemy5()
    {
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(60.32f, 62.35f),
                                            Random.Range(26.24f, 27.4f));

            MoveTowardsEnemyChildLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyChildLevel>
                ();

            mt.health = 2;
        }
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(68.97f, 69.96f),
                                            Random.Range(30.83f, 33.27f));

            MoveTowardsEnemyChildLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyChildLevel>
                ();

            mt.health = 2;
        }
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(77.1f, 81.75f),
                                            Random.Range(38.5f, 40.94f));

            MoveTowardsEnemyChildLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyChildLevel>
                ();

            mt.health = 2;
        }
    }
    public void spawnStationaryEnemy5()
    {
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(60.5f, 21.59f);

            StationaryEnemyChildLevel se = GameObject.FindObjectOfType<StationaryEnemyChildLevel>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(70.42f, 36.58f);

            StationaryEnemyChildLevel se = GameObject.FindObjectOfType<StationaryEnemyChildLevel>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(78.61f, 43.43f);

            StationaryEnemyChildLevel se = GameObject.FindObjectOfType<StationaryEnemyChildLevel>
                ();

            se.health = 1;
        }
    }
    public void spawnBossBehaviour()
    {
        GameObject newBoss = Instantiate(ChildBoss);

        newBoss.transform.rotation = transform.rotation;

        newBoss.transform.position = new Vector2(34.85697f, 56.4157f);
    }
}
