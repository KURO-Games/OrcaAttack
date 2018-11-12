using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedGenerator : MonoBehaviour {
    public GameObject FeedPrefab;
    float span = 10.0f;
    float delta = 0;

    private void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            GameObject go = Instantiate(FeedPrefab) as GameObject;
            float px = Random.Range(-3, 3);
            float py = Random.Range(3, 5);
            go.transform.position = new Vector3(px, py, 0);
        }
    }
    void Update ()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(FeedPrefab) as GameObject;
            float px = Random.Range(-3, 3);
            float py = Random.Range(3, 5);
            go.transform.position = new Vector3(px, py, 0);

        }
	}
}
