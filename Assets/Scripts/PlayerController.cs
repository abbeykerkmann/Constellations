using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private static float speed = 10;
    public static float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    private float verticalInput;
    private float horizontalInput;
    private float verticalBound = 10;
    private float horizontalBound = 22.5f;
    private EventManager eventManager;

    // Start is called before the first frame update
    void Start()
    {
        eventManager = GameObject.Find("EventSystem").GetComponent<EventManager>();
        eventManager.UpdateStarCounters();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the player up and down
        transform.Translate(Vector3.up * verticalInput * Speed * Time.deltaTime);
        if (transform.position.y > verticalBound)
        {
            transform.position = new Vector3(transform.position.x, verticalBound, transform.position.z);
        }
        if (transform.position.y < -verticalBound)
        {
            transform.position = new Vector3(transform.position.x, -verticalBound, transform.position.z);
        }

        // Move the player right and left
        transform.Translate(Vector3.right * horizontalInput * Speed * Time.deltaTime);
        if (transform.position.x > horizontalBound)
        {
            transform.position = new Vector3(horizontalBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -horizontalBound)
        {
            transform.position = new Vector3(-horizontalBound, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Star"))
        {
            eventManager.AddStar(ConstellationManager.Instance.PointsPerStar);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("BlackHole"))
        {
            Destroy(gameObject);
            eventManager.GameOver();
        }
    }
}
