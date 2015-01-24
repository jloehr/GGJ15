using UnityEngine;
using System.Collections;

public class checkState : MonoBehaviour {

    public bool save { get; set; }

	void Start () {
        save = true;
	}
    void changeState()
    {
        if (save)
        {

        }
        else
        {

        }
        save = !save;
    }
	
	// Update is called once per frame
	void Update () {

	}

}
