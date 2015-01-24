using UnityEngine;
using System.Collections;

public class getPoints : MonoBehaviour {

    public checkState checkActualState;
	// Use this for initialization

    void OnCollisionEnter(Collision col)
    {
        if ((col.gameObject.tag != "Baby") && (checkActualState.save == true))
        {
            CheckPush Push = GetComponent<CheckPush>();
            if(Push != null)
            {
                Player player = Push.player;
                if (player != null)
                {
                    player.Points += 10;
                    Debug.Log(player.Points);
                }
            }
        }
    }
}
