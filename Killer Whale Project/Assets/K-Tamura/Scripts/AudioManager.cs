using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public AudioSource sound1;
    public AudioSource sound2;
    [SerializeField]
    AudioSource[] audioSources ;
    [SerializeField]
    AudioClip[] AudioClips;

    void Awake()
    {
       audioSources = GetComponents<AudioSource>();
    }

    public void SoundsMan1(int i)
    {
        sound1.clip = AudioClips[i];
        sound1.Play();
    }
    public void SoundsMan2(int i)
    {
        sound2.clip = AudioClips[i];
        sound2.Play();
    }


    void OnCollisionEnter(Collision col)
    {
        //sound1.clip=
        if (col.gameObject.tag == "orca")
        {
            sound1.PlayOneShot(sound1.clip);
        }
        //if (col.gameObject.tag == "sealion")
        //{

        //}
    }
}