    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiderTest : MonoBehaviour
{
    public float forceAmt = 10;

    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }   

    // Update is called once per frame
    void Update()
    {
        //WASD
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward  * forceAmt);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left  * forceAmt);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.forward  * -forceAmt);
        }
        if (Input.GetKey(KeyCode.D))    
        {
            rb.AddForce(Vector3.right  * forceAmt);
        }
        
        //JUMP
        if (Input.GetKey(KeyCode.Space))    
        {
            rb.AddForce(Vector3.up  * forceAmt);
        }
    }
}
