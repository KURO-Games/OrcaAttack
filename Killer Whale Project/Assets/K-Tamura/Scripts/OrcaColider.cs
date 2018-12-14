using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcaColider : MonoBehaviour {
    private GameObject orcacolider;
    private new AudioManager audio;
	// Use this for initialization
	void Start () {
        //orcacolider = GetComponent<Collider>().collider;
        audio = GetComponent<AudioManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        audio.SoundsMan1(0);
        audio.SoundsMan2(1);

        Destroy(collision.gameObject);
    }
}
