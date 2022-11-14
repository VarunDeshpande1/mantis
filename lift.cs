using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.T))
        {
            rb.GetComponent<ConfigurableJoint>();
        }

       /* if(Input.GetKey(KeyCode.Y)) 
        {
            rb.AddRelativeForce(-Vector3.up * speed);

        }*/
    }
}
