using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 600f;

    // Start is called before the first frame update
    /*void Start()
    {
        rb.AddForce(0, 200, 500);
    }
    */

    // Update is called once per frame
    void Update()
    {
        //Add a forward force
        //if (Input.GetKey("w")) {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //}

        /*
        //Add a forward force
        if (Input.GetKey("s")) {
        rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
        */

        //Add right force
        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce *Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //Add left force
        if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce *Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
