using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio2 : MonoBehaviour
{
    private AudioSource myAudioClip;

    void Start()
    {
       myAudioClip = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Point")
        {
            //Debug.Log(other.tag);
            myAudioClip.Play();
        }
    }

}
