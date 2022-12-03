using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField]
    ParticleSystem _particleSystem = null;

    public void EmitParticles(int num)
    {
        if (_particleSystem != null)
        {
            _particleSystem.Emit(num);
        }
    }
}
