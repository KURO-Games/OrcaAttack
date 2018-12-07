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
    private int startCounter = 0;
    [SerializeField]
    AudioManager Audio;
    private void Awake()
    {
        Audio = GetComponent<AudioManager>();
    }
    /*
    private void StartSpawn()
    {
        GameObject go = Instantiate(FeedPrefab) as GameObject;
        FeedPrefab.tag = "Feed1";
        go.name = go.name.Replace("(Clone)", "");
        if(startCounter == 0)
        {
            GameObject obj = (GameObject)Resources.Load("FeedPrefab");
            Instantiate(obj, new Vector3(-3, 3, 0), Quaternion.identity);
            startCounter++;
        }else if(startCounter == 1)
        {
            GameObject obj = (GameObject)Resources.Load("FeedPrefab");
            Instantiate(obj, new Vector3(-3, 5, 0), Quaternion.identity);
            startCounter++;
        }else if(startCounter == 2)
        {
            GameObject obj = (GameObject)Resources.Load("FeedPrefab");
            Instantiate(obj, new Vector3(3, 3, 0), Quaternion.identity);
            startCounter++;
        }else if(startCounter == 3)
        {
            GameObject obj = (GameObject)Resources.Load("FeedPrefab");
            Instantiate(obj, new Vector3(3,0, 0), Quaternion.identity);
            startCounter++;
        }

    }*/
    private void Spawn()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(FeedPrefab) as GameObject;
            FeedPrefab.tag = "Feed1";
            go.name = go.name.Replace("(Clone)", "");
            float px = Random.Range(-3, 3);
            float py = Random.Range(3, 5);
            go.transform.position = new Vector3(px, py, 0);
            counter++;
        }

    }
    private void Start()
    {
        //StartSpawn();
        for(int i = 0; i < 4; i++)
        {
            delta = span + 1;
            Spawn();
        }
        counter = 0;
        startCounter = 0;
        this.FeedPrefab = GameObject.Find("FeedPrefab");
    }
    void Update()
    {
        if (counter < 4)
        {
            Spawn();
        }
    }
}
