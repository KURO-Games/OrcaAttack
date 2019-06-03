using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    
    public AudioSource Sakusaku;
    public AudioSource Feed1;

   

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Sakusaku")
        {
            Sakusaku.PlayOneShot(Sakusaku.clip);
        }
        if (col.gameObject.tag == "Feed1")
        {
            Feed1.PlayOneShot(Feed1.clip);
        }
    }

 //   void Start() {
 //       audioSources = GetComponents<AudioSource>();
 //   }

 //   public void OrcaSound(){
 //       sound1.Play();
 //   }

	//void Update () {
		
	//}
}
