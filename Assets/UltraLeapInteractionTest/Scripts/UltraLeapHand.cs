using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;
using Leap;

public class UltraLeapHand : HandModelBase
{
    [SerializeField]
    GameObject _sphere;

    [SerializeField]
    private Chirality handedness;

    private Hand _hand;

    /// <summary>
    /// The chirality of handedness of this hand.
    /// This can be set in the inspector.
    /// </summary>
    public override Chirality Handedness
    {
        get
        {
            return handedness;
        }
        set { }
    }
    public override ModelType HandModelType
    {
        get
        {
            return ModelType.Graphics;
        }
    }

    public override Hand GetLeapHand()
    {
        return _hand;
    }

    public override void SetLeapHand(Hand hand)
    {
        _hand = hand;
    }

    public override void UpdateHand()
    {
        Vector3 palmPosition = _hand.PalmPosition;

        if (_sphere != null)
        {
            _sphere.transform.position = palmPosition;
        }
    }
}
