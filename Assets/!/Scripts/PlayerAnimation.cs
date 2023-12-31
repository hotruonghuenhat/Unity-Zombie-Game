﻿using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

    Animation _animation; // Biến Animation 
	void Start () {
        // Lấy Animation từ Player 
        _animation = GetComponent<Animation>();
	}
	
    void Update()
    {
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");

        bool runningForward = v > 0;
        bool runningBackward = v < 0;
        bool notRunningForwardOrBackward = v == 0;
        bool runningForwardOrStanding = v >= 0;

        bool runningLeft = h < 0;
        bool runningRight = h > 0;
        bool notRunningLeftOrRight = h == 0;

        bool notRunningAtAll = notRunningForwardOrBackward && notRunningLeftOrRight;

        if (runningForward)
        {
            _animation.Blend("RunForward");
            _animation.Blend("Idle", 0);
            _animation.Blend("RunBackward", 0);
        }
        else if (runningBackward)
        {
            _animation.Blend("RunBackward");
            _animation.Blend("Idle", 0);
            _animation.Blend("RunForward", 0);
        }
        else if (notRunningForwardOrBackward)
        {
            _animation.Blend("RunForward", 0);
            _animation.Blend("RunBackward", 0);
        }

        if ((runningForwardOrStanding && runningRight) || (runningBackward && runningLeft))
        {
            _animation.Blend("RunRight");
            _animation.Blend("Idle", 0);
            _animation.Blend("RunLeft", 0);
        }
        else if ((runningForwardOrStanding && runningLeft) || (runningBackward && runningRight))
        {
            _animation.Blend("RunLeft");
            _animation.Blend("Idle", 0);
            _animation.Blend("RunRight", 0);
        }
        else if (notRunningLeftOrRight)
        {
            _animation.Blend("RunLeft", 0);
            _animation.Blend("RunRight", 0);
        }

        if (notRunningAtAll)
        {
            _animation.CrossFade("Idle");
        }
    }
}
