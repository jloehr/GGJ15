using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public int Points { get; set; }
    public Text Text;
    private int _caught;

    public int caught
    {
        get { return _caught; }
        set { _caught = value;
        if (_caught > 3)
        {
            Text.text = "you Lose";
        }
        }
    }
    

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
        Text.text = "Points: " + Points;
	}
}
