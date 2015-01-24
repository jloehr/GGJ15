using UnityEngine;
using System.Collections;

public class checkState : MonoBehaviour {

    public bool save;
    public bool getCaught;

	void Start () {
        save = true;
        getCaught = false;
        Invoke("SetUnsave", 30);
	}
	
	// Update is called once per frame
	void Update () {

	}

    void SetUnsave()
    {
        Debug.Log("unsicher");
        save = false;
    }

}
