using UnityEngine;
using System.Collections;

public class CheckPush : MonoBehaviour
{
    public Player player;
    public checkState tetst;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Baby")
        {
            player = col.gameObject.GetComponentInParent<Player>();
        }
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
