using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcaColider : MonoBehaviour {
    private GameObject orcacolider;
	// Use this for initialization
	void Start () {
        //orcacolider = GetComponent<Collider>().collider;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
