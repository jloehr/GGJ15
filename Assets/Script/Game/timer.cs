using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

    checkState CheckState;

	// Use this for initialization
	void Start () {
        CheckState = GetComponent<checkState>();
        Invoke("SetUnsafe", 5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void SetUnsafe()
    {
        Debug.Log("unsicher");
        CheckState.changeState();
    }
}
