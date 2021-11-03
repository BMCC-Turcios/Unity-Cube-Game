using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardMovement = 200f;
    public float sideMovement = 200;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardMovement * Time.deltaTime);
        if (forwardMovement < 0)
            forwardMovement = 0;
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } 
        else if (Input.GetKey("d"))
        {
            rb.AddForce(sideMovement * Time.deltaTime, 0,0, ForceMode.VelocityChange);
            rb.AddForce(sideMovement * Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w")&& forwardMovement <= 2000f)
        {
            forwardMovement += 100f * Time.deltaTime;
        }
        else if (Input.GetKey("s") && forwardMovement > 0)
        {
            forwardMovement -= 100f *Time.deltaTime;
        }

        if(rb.position.y  < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
