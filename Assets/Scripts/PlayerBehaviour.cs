using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 5;

    public GameObject scenePanel;

    public GameObject TriggerFirstRoomEnemies;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        float yMove = Input.GetAxis("Vertical");
        float xMove = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2();

        movement.x = xMove;
        movement.y = yMove;

        movement *= Time.fixedDeltaTime * speed;

        rb.MovePosition(rb.position + movement);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if(collidedObject.name.Contains("Door"))
        {
            scenePanel.gameObject.SetActive(true);
        }
        if (collidedObject.name.Contains("TriggerFirstRoomEnemies"))
        {
            GameController gc = GameObject.FindObjectOfType<GameController>();
            gc.spawnMoveTowardsEnemy();
            Destroy(TriggerFirstRoomEnemies);
        }
        if (collidedObject.name.Contains("TriggerFirstRoomEnemies"))
        {
            GameController gc = GameObject.FindObjectOfType<GameController>();
            gc.spawnStationaryEnemy();
        }
    }
}
