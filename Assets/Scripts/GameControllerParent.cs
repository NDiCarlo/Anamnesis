using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerParent : MonoBehaviour
{
    private int enemiesPerWave = 6;

    private int enemiesPerWave2 = 2;

    private int enemiesPerWave3 = 4;

    private int enemiesPerWave4 = 1;

    private int enemiesPerWave5 = 2;

    private int enemiesPerWave6 = 1;

    public GameObject moveTowardsEnemyParent;

    public GameObject stationaryEnemyParent;

    public float numberofEnemies = 68;

    public GameObject spawnRoomBarricade;

    public GameObject secondHallwayBarricade;

    public GameObject secondRoomBarricade;

    public GameObject fourthHallwayBarricade;

    public GameObject player;

    public GameObject mainMenu;
    public GameObject restart;
    public GameObject resume;

    public GameObject ParentBoss;

    public GameObject instantiateBosstrigger;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawnMoveTowardsEnemy8", 6f);
        Invoke("spawnStationaryEnemy8", 6f);
    }

    // Update is called once per frame
    void Update()
    {
        if(numberofEnemies == 62)
        {
            Destroy(spawnRoomBarricade);
        }
        if (numberofEnemies == 34)
        {
            Destroy(secondHallwayBarricade);
        }
        if (numberofEnemies == 14)
        {
            Destroy(secondRoomBarricade);
        }
        if(numberofEnemies == 0)
        {
            Destroy(fourthHallwayBarricade);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
            mainMenu.SetActive(true);
            restart.SetActive(true);
            resume.SetActive(true);

            player.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
    public void spawnMoveTowardsEnemy()
    {
        for (int i = 0; i < enemiesPerWave; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-77.3f, -28.9f),
                                            Random.Range(109.8f, 74.2f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 2;
        }
    }
    public void spawnStationaryEnemy()
    {
        for (int i = 0; i < enemiesPerWave2; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-77.7f, -28.7f),
                                            Random.Range(114.4f, 114.4f));

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
    }

    public void spawnMoveTowardsEnemy2()
    {
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-12.7f, -8f),
                                            Random.Range(-3.2f, -16.9f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 2;
        }
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-73.1f, -67.5f),
                                            Random.Range(-5.2f, -15.8f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 2;
        }
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-76.4f, -68f),
                                            Random.Range(19.1f, 12.4f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 2;
        }
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-76.2f, -65.5f),
                                            Random.Range(60.3f, 48.3f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 2;
        }
    }
    public void spawnStationaryEnemy2()
    {
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(-13.1f, -2.4f);

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(-61.1f, -3.9f);

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(-78.7f, 26.4f);

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(-63.7f, 55.9f);

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
    }
    public void spawnMoveTowardsEnemy3()
    {
        for (int i = 0; i < enemiesPerWave5; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(-3.4f, -0.5f),
                                            Random.Range(98.9f, 87.6f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 2;
        }
        for (int i = 0; i < enemiesPerWave5; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(10f, 13f),
                                            Random.Range(98.5f, 87.3f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 2;
        }
        for (int i = 0; i < enemiesPerWave5; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(37.1f, 47.4f),
                                            Random.Range(97.6f, 87.5f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 2;
        }
        for (int i = 0; i < enemiesPerWave5; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(38.6f, 46.8f),
                                            Random.Range(72.6f, 77.4f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 2;
        }
    }
    public void spawnStationaryEnemy3()
    {
        for (int i = 0; i < enemiesPerWave6; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(0.8f, 99.4f);

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave6; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(29.4f, 86.8f);

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave6; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(49.2f, 70.9f);

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave6; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(49.4f, 99.2f);

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
    }

    public void spawnMoveTowardsEnemy4()
    {
        for (int i = 0; i < enemiesPerWave; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(38.1f, 82.7f),
                                            Random.Range(52.9f, 28.2f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 4;
        }
    }
    public void spawnStationaryEnemy4()
    {
        for (int i = 0; i < enemiesPerWave2; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(81.9f, 39.6f),
                                            Random.Range(29.5f, 29.5f));

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 2;
        }
    }
    public void spawnMoveTowardsEnemy5()
    {
        for (int i = 0; i < enemiesPerWave5; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(74.8f, 84f),
                                            Random.Range(66.4f, 70.1f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 2;
        }
        for (int i = 0; i < enemiesPerWave5; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(82.5f, 85.7f),
                                            Random.Range(81.8f, 86.8f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 2;
        }
        for (int i = 0; i < enemiesPerWave5; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(97.9f, 100.9f),
                                            Random.Range(86.8f, 80.1f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 2;
        }
    }
    public void spawnStationaryEnemy5()
    {
        for (int i = 0; i < enemiesPerWave6; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(73.1f, 70.4f);

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave6; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(73.02f, 86.98f);

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave6; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(104f, 79f);

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
    }
    public void spawnMoveTowardsEnemy6()
    {
        for (int i = 0; i < enemiesPerWave3; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(111f, 127.7f),
                                            Random.Range(93.2f, 73.6f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 3;
        }
    }
    public void spawnStationaryEnemy6()
    {
        for (int i = 0; i < enemiesPerWave6; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(129.7f, 130f),
                                            Random.Range(93.9f, 73f));

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 2;
        }
    }
    public void spawnMoveTowardsEnemy7()
    {
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(118.5f, 120.5f),
                                            Random.Range(66.6f, 63.6f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 1;
        }
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(118.5f, 120.5f),
                                            Random.Range(54.5f, 52.7f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 1;
        }
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(118.5f, 120.5f),
                                            Random.Range(45.2f, 40.9f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 1;
        }
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(118.5f, 120.5f),
                                            Random.Range(32f, 28.6f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 1;
        }
    }
    public void spawnStationaryEnemy7()
    {
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(118.2f, 53.6f);

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
        for (int i = 0; i < enemiesPerWave4; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(121.1f, 41.3f);

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
    }
    public void spawnMoveTowardsEnemy8()
    {
        for (int i = 0; i < enemiesPerWave2; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(25.3f, 54.9f),
                                            Random.Range(2.6f, 11f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 2;
        }
        for (int i = 0; i < enemiesPerWave2; ++i)
        {
            GameObject newEnemy = Instantiate(moveTowardsEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(25.3f, 54.9f),
                                            Random.Range(-22f, -30.4f));

            MoveTowardsEnemyParentLevel mt = GameObject.FindObjectOfType<MoveTowardsEnemyParentLevel>
                ();

            mt.health = 2;
        }
    }
    public void spawnStationaryEnemy8()
    {
        for (int i = 0; i < enemiesPerWave2; ++i)
        {
            GameObject newEnemy = Instantiate(stationaryEnemyParent);

            newEnemy.transform.rotation = transform.rotation;

            newEnemy.transform.position = new Vector2(Random.Range(61.1f, 61.1f),
                                            Random.Range(11.6f, -31.3f));

            StationaryEnemyParentLevel se = GameObject.FindObjectOfType<StationaryEnemyParentLevel>
                ();

            se.health = 1;
        }
    }
        public void spawnBossBehaviour()
        {
            GameObject newBoss = Instantiate(ParentBoss);

            newBoss.transform.rotation = transform.rotation;

            newBoss.transform.position = new Vector2(119.9f, -9.3f);

            Destroy(instantiateBosstrigger);

        }
    }