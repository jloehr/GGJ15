using UnityEngine;
using System.Collections;

public class CheckPush : MonoBehaviour
{

    public checkState tetst;
    void OnCollisionEnter()
    {
        //if (tetst.save == false) { Debug.Log("erwischt"); }
        //Debug.Log("Hit");
    }
    void Update()
    {
        if ((tetst.save == false) && (rigidbody.velocity.y > 1))
        {
            Debug.Log("erwischt");
        }
    }
}
