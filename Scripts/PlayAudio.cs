using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    private AudioSource AudioClip;
    public float Semitones;

    void Start()
    {
        AudioClip = GetComponent<AudioSource>();

        // 1.05946 ^ n changes pitch of audioclip by n semitones
        AudioClip.pitch += Mathf.Pow(1.0594631f, Semitones);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Point")
        {
            //Debug.Log(other.tag);
            AudioClip.Play();
        }
    }
}
