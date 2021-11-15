using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject moveTowardsEnemy;

    public GameObject stationaryEnemy;

    private int enemiesPerWave = 4;

    private int enemiesPerWave2 = 2;

    private int enemiesPerWave3 = 2;

    private int enemiesPerWave4 = 1;

    public GameObject FirstRoomBarricade;

    public GameObject SecondRoomBarricade;

    public GameObject ThirdRoomBarricade;

    public int numberofEnemies = 54;

    public GameObject LoverLevelBoss;

    public GameObject player;

    public GameObject mainMenu;
    public GameObject restart;
    public GameObject resume;
    // Start is called before the first frame update
    void Start()
    {
        spawnMoveTowardsEnemy4();
        spawnStationaryEnemy4();
    }

    // Update is called once per frame
    void Update()
    {
        if (numberofEnemies == 39)
        {
            Destroy(FirstRoomBarricade);
        }
        if (numberofEnemies == 24)
        {
            Destroy(SecondRoomBarricade);
        }
        if (numberofEnemies == 9)
        {
            Destroy(ThirdRoomBarricade);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
            mainMenu.SetActive(true);
            restart.SetActive(true);
            resume.SetActive(true);

            player.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            SceneManager.LoadScene("ParentLevelOpen");
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

            MoveTowardsEnemyBehaviour mt = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
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

            newEnemy.transform.position = new Vector2(Random.Range(-64f, -25),
                                            Random.Range(55.46499f, 55.46499f));

            StationaryEnemyBehaviour se = GameObject.FindObjectOfType<StationaryEnemyBehaviour>
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

            newEnemy.transform.position = new Vector2(Random.Range(13f, 50),
                                            Random.Range(67, 52));

            MoveTowardsEnemyBehaviour mt = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
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

            newEnemy.transform.position = new Vector2(Random.Range(21f, 40),
                                            Random.Range(67.5f, 67.5f));

            StationaryEnemyBehaviour se = GameObject.FindObjectOfType<StationaryEnemyBehaviour>
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

            newEnemy.transform.position = new Vector2(Random.Range(81f, 130f),
                                            Random.Range(55f, 42f));

            MoveTowardsEnemyBehaviour mt = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
                ();

            mt.health = 6;
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

            StationaryEnemyBehaviour se = GameObject.FindObjectOfType<StationaryEnemyBehaviour>
                ();

            se.health = 3;
        }
    }
    public void spawnMoveTowardsEnemy4()
    {
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-3.5f, 3.5f),
                                            Random.Range(5f, 6f));

            MoveTowardsEnemyBehaviour mt = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
                ();

            mt.health = 1;
        }
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-16f, -17f),
                                            Random.Range(12f, 12.4f));

            MoveTowardsEnemyBehaviour mt = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
                ();

            mt.health = 1;
        }
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-37f, -34f),
                                            Random.Range(23f, 25f));

            MoveTowardsEnemyBehaviour mt = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
                ();

            mt.health = 1;
        }
    }
    public void spawnStationaryEnemy4()
    {
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(-4.7f, 6.6f);

            StationaryEnemyBehaviour se = GameObject.FindObjectOfType<StationaryEnemyBehaviour>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(-31.6f, 20.6f);

            StationaryEnemyBehaviour se = GameObject.FindObjectOfType<StationaryEnemyBehaviour>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(-44.5f, 37.3f);

            StationaryEnemyBehaviour se = GameObject.FindObjectOfType<StationaryEnemyBehaviour>
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

            newEnemy.transform.position = new Vector2(Random.Range(-42.8f, -39.6f),
                                            Random.Range(71f, 76.1f));

            MoveTowardsEnemyBehaviour mt = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
               ();

            mt.health = 2;
        }

            for (int i = 0; i < enemiesPerWave3; ++i)
            {
                GameObject newEnemy = Instantiate(moveTowardsEnemy);

                newEnemy.transform.rotation = transform.rotation;

                newEnemy.transform.position = new Vector2(Random.Range(19f, 21F),
                                            Random.Range(91f, 77f));

                MoveTowardsEnemyBehaviour mt1 = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
                    ();

                mt1.health = 2;
            }

            for (int i = 0; i < enemiesPerWave3; ++i)
            {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-19f, -5f),
                                        Random.Range(104f, 99f));

            MoveTowardsEnemyBehaviour mt1 = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
                ();

            mt1.health = 2;
        }
    }
    public void spawnStationaryEnemy5()
    {
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(-35f, 87f);

            StationaryEnemyBehaviour se = GameObject.FindObjectOfType<StationaryEnemyBehaviour>
                ();

            se.health = 1;
        }

        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(-13f, 105f);

            StationaryEnemyBehaviour se = GameObject.FindObjectOfType<StationaryEnemyBehaviour>
                ();

            se.health = 1;
        }

        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(25.07f, 80.72f);

            StationaryEnemyBehaviour se = GameObject.FindObjectOfType<StationaryEnemyBehaviour>
                ();

            se.health = 1;
        }
    }
    public void spawnMoveTowardsEnemy6()
    {
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(46f, 48f),
                                            Random.Range(97f, 84f));

            MoveTowardsEnemyBehaviour mt = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
               ();

            mt.health = 2;
        }

        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(69f, 82f),
                                        Random.Range(93f, 100f));

            MoveTowardsEnemyBehaviour mt1 = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
                ();

            mt1.health = 2;
        }

        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(100f, 104f),
                                        Random.Range(84f, 67f));

            MoveTowardsEnemyBehaviour mt1 = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
                ();

            mt1.health = 2;
        }
    }
    public void spawnStationaryEnemy6()
    {
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(52.51f, 90.2f);

            StationaryEnemyBehaviour se = GameObject.FindObjectOfType<StationaryEnemyBehaviour>
                ();

            se.health = 1;
        }

        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(75.24f, 101.1f);

            StationaryEnemyBehaviour se = GameObject.FindObjectOfType<StationaryEnemyBehaviour>
                ();

            se.health = 1;
        }

        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(108.79f, 67.87f);

            StationaryEnemyBehaviour se = GameObject.FindObjectOfType<StationaryEnemyBehaviour>
                ();

            se.health = 1;
        }
    }
    public void spawnMoveTowardsEnemy7()
    {
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(90f, 92f),
                                            Random.Range(21f, 19f));

            MoveTowardsEnemyBehaviour mt = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
               ();

            mt.health = 2;
        }

        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(83f, 84f),
                                        Random.Range(3f, 6f));

            MoveTowardsEnemyBehaviour mt1 = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
                ();

            mt1.health = 2;
        }

        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(69f, 70f),
                                        Random.Range(-6f, -9f));

            MoveTowardsEnemyBehaviour mt1 = GameObject.FindObjectOfType<MoveTowardsEnemyBehaviour>
                ();

            mt1.health = 2;
        }
    }
    public void spawnStationaryEnemy7()
    {
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(90.9f, 17.6f);

            StationaryEnemyBehaviour se = GameObject.FindObjectOfType<StationaryEnemyBehaviour>
                ();

            se.health = 1;
        }

        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemy);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(77.9f, -0.4f);

            StationaryEnemyBehaviour se = GameObject.FindObjectOfType<StationaryEnemyBehaviour>
                ();

            se.health = 1;
        }
    }

    public void spawnBossBehaviour()
    {
        GameObject newBoss = Instantiate(LoverLevelBoss);

        newBoss.transform.rotation = transform.rotation;

        newBoss.transform.position = new Vector2(34.9f, -35.2f);

    }
}