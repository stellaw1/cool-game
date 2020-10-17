using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool jumpable = false;
    public Rigidbody rb;
    public float speed = 20f;
    public float jumpHeight = 200f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        // float y = Input.GetAxis("Jump") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position += new Vector3(x, 0, z);

        // jump
        if (Input.GetKey("space"))
        {
            if (jumpable) 
            {
                jumpable = false;
                // Debug.Log("Jump: " + transform.position.y);
                rb.AddForce(0, jumpHeight, 0);
            }
        }
    }

    void OnCollisionEnter (Collision collisionInfo) 
    {
        // Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Terrain") 
        {
            jumpable = true;
        }
    }
}
