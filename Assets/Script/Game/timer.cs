using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

    checkState CheckState;
    public float SafeTimeBase = 10;
    public float SafeTimeRange = 20;
    public float UnsafeTimeBase = 5;
    public float UnsafeTimeRange = 5;

	// Use this for initialization
	void Start () {
        CheckState = GetComponent<checkState>();

        Invoke("SetUnsafe", GetSafeTime());
	}
	
    float GetUnsafeTime()
    {
        return ((Random.value * UnsafeTimeRange) + UnsafeTimeBase);
    }
    float GetSafeTime()
    {
        return ((Random.value * SafeTimeRange) + SafeTimeBase);
    }

	// Update is called once per frame
	void Update () {
	
	}
    void SetUnsafe()
    {
        CheckState.changeState();
        Invoke("SetSafe", GetUnsafeTime());
    }
    void SetSafe()
    {
        CheckState.changeState();
        Invoke("SetUnsafe", GetSafeTime());
    }
}
