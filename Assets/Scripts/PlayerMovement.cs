using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    public float gravity = 25f; 
    public float groundY = -3.5f;
    private float verticalSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal * speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y <= groundY)
        {
            verticalSpeed = jumpForce;
        }

        verticalSpeed -= gravity * Time.deltaTime;

        transform.position += new Vector3(0, verticalSpeed * Time.deltaTime, 0);

        if (transform.position.y < groundY)
        {
            transform.position = new Vector3(transform.position.x, groundY, 0);
            verticalSpeed = 0f;
        }
    }
}
