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
            anim.Play("turnRight");
        }
        else
        {
            anim.Play("turnLeft");
        }
        save = !save;
    }

}
