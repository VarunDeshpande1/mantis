using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    public float speed, turnSpeed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed * 10);
        }
       if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(-Vector3.forward * speed * 10);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(-Vector3.up * turnSpeed * 10);
        }
        
         if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(Vector3.up * turnSpeed * 10);
        }

    }
}
