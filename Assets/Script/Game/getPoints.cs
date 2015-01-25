using UnityEngine;
using System.Collections;

public class getPoints : MonoBehaviour {

	// Use this for initialization
    void OnCollisionEnter(Collision col)
    {
        if ((col.gameObject.tag != "Baby") && (col.gameObject.tag != "Object") && (col.gameObject.tag != "NoPoints") && (MotherSingleton.Instance.CheckState.save == true))
        {
            CheckPush Push = GetComponent<CheckPush>();
            if(Push != null)
            {
                Player player = Push.player;
                if (player != null)
                {
                    player.Points += 10;
                    Push.player = null;
                }
            }
        }
    }
}
