using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class FakeScript : MonoBehaviour
{ 
    public bool inSocket = true;
    public UnityEvent onSelect;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the game object is in a socket
        if (other.CompareTag("Socket"))
        {
            inSocket = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the game object is no longer in a socket
        if (other.CompareTag("Socket"))
        {
            inSocket = false;
        }
    }

    public void OnSelect(XRBaseInteractor interactor)
    {
        if (!inSocket)
        {
            onSelect.Invoke();
        }
    }
}
