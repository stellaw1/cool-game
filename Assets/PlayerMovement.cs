using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    // public float forwardForce = 2000f;
    public float moveForce = 2000f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // forward
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, moveForce * Time.deltaTime);
        }
        
        // backward
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -moveForce * Time.deltaTime);
        }

        // right
        if (Input.GetKey("d"))
        {
            rb.AddForce(moveForce * Time.deltaTime, 0, 0);
        }
        
        // left
        if (Input.GetKey("a"))
        {
            rb.AddForce(-moveForce * Time.deltaTime, 0, 0);
        }

        // up
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, moveForce * Time.deltaTime, 0);
        }

    }
}
