using UnityEngine;
using System.Collections;

public class getPoints : MonoBehaviour {

    public checkState checkActualState;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if ((col.gameObject.tag != "Baby") && (checkActualState.save == true))
        {
            Player player = GetComponent<Player>();
            if(player != null)
            {
                player.Points += 10;
                Debug.Log(player.Points);
            }
        }
    }
}
