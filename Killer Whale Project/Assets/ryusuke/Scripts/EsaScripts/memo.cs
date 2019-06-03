using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memo : MonoBehaviour {



	// Use this for initialization
	void Start () {
        StartCoroutine("Coroutine");
	}

    bool atari;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            atari = true;
        }

        if (atari == true)
        {

            GetComponent<BoxCollider>().enabled = false;
        }
	}

    IEnumerator Coroutine()
    {

        yield return new WaitForSeconds(1.0f);

    }
}
