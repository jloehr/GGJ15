using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public int Points { get; set; }
    public Text PointsText;
    public Text CaughtText;
    public Text LooseText;
    private int _caught;

    public int caught
    {
        get { return _caught; }
        set { _caught = value;
        if (_caught >= 3)
            {
                LooseText.enabled = true;
                Invoke("Restart", 10);
            }
        else if( _caught > 0)
        {
            CaughtText.enabled = true;
            CancelInvoke("HideCaughtText");
            Invoke("HideCaughtText", 5);
        }
        }
    }


    void HideCaughtText()
    {
        CaughtText.enabled = false;
    }

    void Restart()
    {
        _caught = 0;
        Points = 0;
        LooseText.enabled = false;
    }

	// Update is called once per frame
	void Update () {
        if(_caught < 3)
        {
            PointsText.text = "Points: " + Points;
        }
	}
}
