using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeiutiSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject SeiutiPrefab;
    [SerializeField]
    private float span = 0;
    [SerializeField]
    private float delta = 0;
    [SerializeField]
    private float Speed = 2;
    [SerializeField]
    private int counter = 0;
    [SerializeField]
    AudioManager Audio;
    public Vector3 pos;
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
            GameObject go = Instantiate(SeiutiPrefab) as GameObject;
            go.name = go.name.Replace("(Clone)", "");
            float px = Random.Range(6, -6);
            float py = Random.Range(15f, 15f);
            go.transform.position = new Vector3(px, py, 16.1f);
            //this.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            Vector3 pos = transform.position;
            transform.position = pos;
            counter++;
        }
    }
    private void Start()
    {
        //最初の四体呼び出し
        for (int i = 0; i < 1; i++)
        {
            delta = span + 1;
            Spawn();
        }
        counter = 0;
    }
    public void Count(int count)
    {
        counter -= count;
    }
    void Update()
    {
        //4体まで生成
        if (counter < 1)
        {
            Spawn();
        }
    }
}
