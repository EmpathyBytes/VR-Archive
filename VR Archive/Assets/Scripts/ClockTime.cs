using System;
using UnityEngine;

public class ClockTime : MonoBehaviour
{
    [SerializeField] private Transform secondHand;
    [SerializeField] private Transform minuteHand;
    [SerializeField] private Transform hourHand;

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        secondHand.localRotation = Quaternion.Euler(time.Second * 6f + 90f, 0f, -90f);
        minuteHand.localRotation = Quaternion.Euler(time.Minute * 6f + 90f, 0f, -90f);
        hourHand.localRotation = Quaternion.Euler(time.Hour * 30f + 90f, 0f, -90f);
    }
}
