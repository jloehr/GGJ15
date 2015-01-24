using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public int Points { get; set; }
    public Text Text;
    

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
        Text.text = "Points: " + Points;
	}
}
