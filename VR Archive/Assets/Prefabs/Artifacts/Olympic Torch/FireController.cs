using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    ParticleSystem fire;
    // Start is called before the first frame update
    void Start()
    {
        fire = GetComponent<ParticleSystem>();
    }

    public void TurnFireOn()
    {
        fire.Play();
    }

    public void TurnFireOff()
    {
        fire.Stop();
    }
}
