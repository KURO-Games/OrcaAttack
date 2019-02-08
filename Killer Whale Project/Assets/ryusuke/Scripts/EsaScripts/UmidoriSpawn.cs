﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmidoriSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject UmidoriPrefab;
    [SerializeField]
    private AudioClip[] audioClip;
    [SerializeField]
    private AudioSource[] sounds;
    [SerializeField]
    AudioManager Audio;
    public Vector3 pos;
    private void Awake()
    {
        Audio = GetComponent<AudioManager>();
    }

    public void Spawn()
    {
        GameObject go = Instantiate(UmidoriPrefab) as GameObject;
        go.name = go.name.Replace("(Clone)", "");
        float px = Random.Range(8, -6);
        float py = Random.Range(2f, 2f);
        go.transform.position = new Vector3(px, py, 16.1f);
        //this.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        Vector3 pos = transform.position;
        transform.position = pos;
        sounds[0].PlayOneShot(audioClip[0]);
    }
}
