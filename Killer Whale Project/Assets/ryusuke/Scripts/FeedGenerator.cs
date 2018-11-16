using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedGenerator : MonoBehaviour
{
    public GameObject FeedPrefab;
    [SerializeField]
    private float span = 10.0f;
    [SerializeField]
    private float delta = 0;
    [SerializeField]
    private float Speed = 2;
    [SerializeField]
    private int counter = 0;
    [SerializeField]
    AudioManager Audio;
    private void Awake()
    {
        Audio = GetComponent<AudioManager>();
    }
    private void Spawn()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
                this.delta = 0;
                GameObject go = Instantiate(FeedPrefab) as GameObject;
                go.name = go.name.Replace("(Clone)", "");
                float px = Random.Range(-3, 3);
                float py = Random.Range(3, 5);
                go.transform.position = new Vector3(px, py, 0);
                counter++;
        }

    }
    private void Start()

    {/*
        for (int i = 0; i < 4; i++)
        {
            GameObject go = Instantiate(FeedPrefab) as GameObject;
            go.name = go.name.Replace("(Clone)", "");
            float px = Random.Range(-3, 3);
            float py = Random.Range(3, 5);
            go.transform.position = new Vector3(px, py, 0);
            //transform.Translate(1 * Speed * Time.deltaTime, 0, 0);
        }
        */
       
        for (int i = 0; i < 4; i++)
        {
            counter += 4;
            delta = span+1;
            Spawn();
            counter = 0;
        }
    }
    void Update()
    {
        if(counter < 4)
        {
            Spawn();
        }
    }



}
