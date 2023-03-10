using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InHand : MonoBehaviour
{
    private bool objectSelected = false;
    public bool inSocket = false;
    public Canvas infoCard;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Socket"))
        {
            inSocket = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Socket")) {
            inSocket = false;
        }
    }

    public void Update()
    {
        if (objectSelected) {
            if (!inSocket)
            {
                infoCard.gameObject.SetActive(true);
            }
        }
    }

    public void setObjectSelected()
    {
        objectSelected = true;
    }

    public void setObjectNotSelected()
    {
        objectSelected = false;
        infoCard.gameObject.SetActive(false);
    }
}
