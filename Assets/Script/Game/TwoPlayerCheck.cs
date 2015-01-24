using UnityEngine;
using System.Collections;

public class TwoPlayerCheck : MonoBehaviour {

    public SkeletonWrapper KinectSkeleton;

    public Camera PlayerOne;
    public Camera PlayerTwo;

    bool SinglePlayer;

    void Start()
    {
        SinglePlayer = true;

        Rect PlayerOneRect = new Rect(0, 0, 1, 1);
        PlayerOne.rect = PlayerOneRect;

        Rect PlayerTwoRect = new Rect(0.5f, 0, 0.5f, 1);
        PlayerTwo.rect = PlayerTwoRect;
        PlayerTwo.enabled = false;
    }

    void Update()
    {
        if(KinectSkeleton.pollSkeleton())
        {
            bool TwoSkeletons = (KinectSkeleton.trackedPlayers[1] >= 0);
            
            if(SinglePlayer && TwoSkeletons)
            {
                ChangeToSplitscreen();
            }

            if(!SinglePlayer && !TwoSkeletons)
            {
                ChangeToFullscreen();
            }
        }
    }

    void ChangeToSplitscreen()
    {
        SinglePlayer = false;

        Rect PlayerOneRect = PlayerOne.rect;
        PlayerOneRect.width = 0.5f;
        PlayerOne.rect = PlayerOneRect;

        PlayerTwo.enabled = true;
    }

    void ChangeToFullscreen()
    {
        SinglePlayer = true;

        Rect PlayerOneRect = PlayerOne.rect;
        PlayerOneRect.width = 1f;
        PlayerOne.rect = PlayerOneRect;

        PlayerTwo.enabled = false;
    }
}
