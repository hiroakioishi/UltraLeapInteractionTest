using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class UltraLeapHandEnableDisable : HandTransitionBehavior
{

    [Tooltip("When enabled, freezes the hand in its current active state")]
    public bool FreezeHandState = false;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void HandReset()
    {
        if (FreezeHandState)
        {
            return;
        }

        gameObject.SetActive(true);
    }

    protected override void HandFinish()
    {
        if (FreezeHandState)
        {
            return;
        }
        gameObject.SetActive(false);
    }
}
