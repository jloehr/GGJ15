using UnityEngine;
using System.Collections;

public class MotherSingleton : MonoBehaviour {

    public static MotherSingleton Instance;

    public GameObject Mama;
    [HideInInspector]
    public checkState CheckState;


	// Use this for initialization
	void Start () {
	    if(Instance == null)
        {
            Instance = this;
        }

        if(Mama == null)
        {
            return;
        }

        CheckState = Mama.GetComponent<checkState>();
	}
}
