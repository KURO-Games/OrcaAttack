using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class OPV : MonoBehaviour {
    [SerializeField]
    private VideoClip vi;
    [SerializeField]
    private VideoSource vs;
    [SerializeField]
    private VideoPlayer Vplayer;
    [SerializeField]
    private string SceneName;
    [SerializeField]
    private AudioSource audioSource;
    // Use this for initialization
    private void Awake()
    {
        Vplayer.source = vs;
        Vplayer.clip = vi;
        Vplayer.Play();
        Vplayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        Vplayer.EnableAudioTrack(0, true);
        Vplayer.SetTargetAudioSource(0, audioSource);

    }

    void Start () {
       
        	
	}

    // Update is called once per frame

    void Update()
    {

        if (Vplayer.time == vi.length)
        {
            SceneManager.LoadScene(SceneName);
        }
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
