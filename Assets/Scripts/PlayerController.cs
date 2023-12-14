using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10;
    private float verticalInput;
    private float horizontalInput;
    private float verticalBound = 10;
    private float horizontalBound = 22.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the player up and down
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);
        if (transform.position.y > verticalBound)
        {
            transform.position = new Vector3(transform.position.x, verticalBound, transform.position.z);
        }
        if (transform.position.y < -verticalBound)
        {
            transform.position = new Vector3(transform.position.x, -verticalBound, transform.position.z);
        }

        // Move the player right and left
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        if (transform.position.x > horizontalBound)
        {
            transform.position = new Vector3(horizontalBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -horizontalBound)
        {
            transform.position = new Vector3(-horizontalBound, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Star"))
        {
            Debug.Log("collected a star");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("BlackHole"))
        {
            Debug.Log("touched a black hole");
            Destroy(gameObject);
        }
    }
}
