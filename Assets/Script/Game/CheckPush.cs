using UnityEngine;
using System.Collections;

public class CheckPush : MonoBehaviour
{
    public Player player;

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
        if ((MotherSingleton.Instance.CheckState.save == false) && (rigidbody.velocity.y > 1))
        {
            player.Points -= 30;
            player = null;
            player.caught++;
        }
    }
}
