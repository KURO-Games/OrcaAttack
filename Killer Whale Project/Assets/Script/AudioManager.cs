using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public AudioSource sound1;
    public AudioSource sound2;

    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "orca")
        {
            sound1.PlayOneShot(sound1.clip);
        }
        //if (col.gameObject.tag == "sealion")
        //{

        //}
    }
}