using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pullPush : MonoBehaviour
{
    public float distance;
    public LayerMask boxmask;
    bool adcomp = false;
    GameObject box;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(Physics.Raycast(transform.position, Vector3.forward * transform.localScale.x,out RaycastHit hitinfo, distance, boxmask) && !adcomp && Input.GetKey(KeyCode.E))
        {
                                                                                                            //latch
            gameObject.AddComponent<FixedJoint>();
            gameObject.GetComponent<FixedJoint>().connectedBody = hitinfo.collider.attachedRigidbody; 
            Debug.Log("hit");
            adcomp = true;
        }
        else { Debug.Log("miss"); }
        if (Input.GetKey(KeyCode.F))                                                                        //Unlatch
        {
            Destroy(gameObject.GetComponent<FixedJoint>());
            adcomp = false;
        }

        if (Input.GetKey(KeyCode.G))                                                                        //Emergency stop
        {
            gameObject.GetComponent<Rigidbody>().mass = 10000;
           
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawLine(transform.position, (Vector3)transform.position + Vector3.forward * transform.localScale.x * distance);
    }

   /* void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() != null )
        {
            gameObject.AddComponent<FixedJoint>();
            gameObject.GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
           

        }
    }*/
}
