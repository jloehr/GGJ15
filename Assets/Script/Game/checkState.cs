using UnityEngine;
using System.Collections;

public class checkState : MonoBehaviour {

    public bool save { get; set; }
    Animator anim;

	void Start () {
        save = true;
        anim = GetComponent<Animator>();
	}
    public void changeState()
    {
        if (save)
        {
            bool test = true;
            anim.SetBool("turnRight", test);
            test = false;
        }
        else
        {
            bool test = true;
            anim.SetBool("turnLeft", test);
            test = false;
        }
        save = !save;
    }
	
	// Update is called once per frame
	void Update () {

	}

}
