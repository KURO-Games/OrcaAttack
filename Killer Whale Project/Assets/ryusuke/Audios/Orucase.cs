using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orucase : MonoBehaviour {


    [SerializeField]
    private AudioClip[] audioClip;
    [SerializeField]
    private AudioSource[] sounds;
    
    void Start()
    {
        //sounds = GetComponents<AudioSource>();
    }

    private void OnCollisionEnter(Collision col)
    {        
        switch (col.gameObject.tag)
        {
            case "Feed1":
                sounds[1].PlayOneShot(audioClip[1]);
                break;
            case "Seiuti":
                sounds[1].PlayOneShot(audioClip[2]);
                break;
            case "Unidori":
                sounds[1].PlayOneShot(audioClip[3]);
                break;
            case "Gomi":
                sounds[1].PlayOneShot(audioClip[4]);
                break;
            case "Gomi2":
                sounds[1].PlayOneShot(audioClip[5]);
                break;
        }
        sounds[0].PlayOneShot(audioClip[0]);
    }




    //private void OnCollisionEnter(Collision col)
    //{
    //    //がぶがぶ音(統一)
    //    if (col.gameObject.tag == "Feed1"||
    //        col.gameObject.tag == "Seiuti"||
    //        col.gameObject.tag == "Umidori"||
    //        col.gameObject.tag == "Gomi"||
    //        col.gameObject.tag == "Gomi2")
    //    {
    //        sounds[0].PlayOneShot(audioClip[0]);
    //    }

    //    if (col.gameObject.tag == "")
    //    {
    //        sounds[1].PlayOneShot(audioClip[1]);
    //    }
    //}
}
