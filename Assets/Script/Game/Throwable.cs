using UnityEngine;
using System.Collections;

public class Throwable : MonoBehaviour {

    bool Attached;
    bool Affected;
    FixedJoint Joint;

    void Start()
    {
        Attached = false;
        Affected = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        //If touched by baby hand, attach
        if((collision.gameObject.tag == "Baby") && (!Attached) && (Affected))
        {
            Joint = gameObject.AddComponent<FixedJoint>();
            //Get the Attachement somewhere at the arm
            Joint.connectedBody = collision.collider.gameObject.transform.parent.GetComponentInChildren<Rigidbody>();
            Attached = true;
            Affected = false;
            Invoke("EnableAffected", 1f);
            rigidbody.velocity = Vector3.zero;         
        }
    }

    void Update()
    {

        if(Affected && Attached && (rigidbody.velocity.magnitude > 50f))
        {
            Destroy(gameObject.GetComponent<FixedJoint>());
            Attached = false;
            Affected = false;
            Invoke("EnableAffected", 1f);
        }
    }
    
    void EnableAffected()
    {
        Affected = true;
    }
}
