using UnityEngine;
using System.Collections;

public class armCollision : MonoBehaviour {

    public checkState tetst;
    void OnCollisionEnter()
    {
        if (tetst.save == false) { Debug.Log("erwischt"); }
        Debug.Log("Hit");
    }
}
