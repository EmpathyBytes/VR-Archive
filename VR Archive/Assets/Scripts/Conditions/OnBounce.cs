using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class OnBounce : MonoBehaviour
{
    //public AudioClip impact;
    AudioSource audioSource;
    Rigidbody rb;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter()
    {
        audioSource.PlayOneShot(audioSource.clip, rb.velocity.magnitude);
    }
}
