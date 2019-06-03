<<<<<<< HEAD:Killer Whale Project/Assets/ryusuke/Scripts/EsaScripts/FeedGenerator.cs
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class FeedGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject FeedPrefab;
    private float span = 2;
    [SerializeField]
    private float delta = 0;
    private float Speed = 2;
    [SerializeField]
    public int counter = 0;
    [SerializeField]
    AudioManager Audio;
    public Vector3 pos;
    private void Awake()
    {
        Audio = GetComponent<AudioManager>();
    }
    /// <summary>
    /// 餌(アシカ)生成
    /// </summary>
    private void Spawn()
    {
        this.delta += Time.deltaTime;
        //deltaがspanの時間を上回ったとき
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(FeedPrefab) as GameObject;
            go.name = go.name.Replace("(Clone)", "");
            //範囲でランダム生成
            float px = Random.Range(-4, 4);
            float py = Random.Range(12, 12);
            //平行移動
            go.transform.position = new Vector3(px, py, 16.1f);
            Vector3 pos = transform.position;
            transform.position = pos;
            counter++;
        }
    }
    private void Start()
    {
        //最初の8体呼び出し(カウントされないようにしている)
        for(int i = 0; i < 3; i++)
        {
            delta = span + 1;
            Spawn();
            counter = 0;
        }
    }
    /// <summary>
    ///以下調整中 
    /// </summary>
    public void Revival()
    {
        //0.5秒後に餌生成
        //Invoke("F",0.5f);
    }
    private void F()
    {
        counter--;
        delta = span + 1;
        Spawn();
    }
    void Update()
    {
        Spawn();
        //餌が0になったら盤面リセット(調整中)
        if(counter == -8)
        {
            Start();
        }
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject FeedPrefab;
    [SerializeField]
    AudioManager Audio;
    public Vector3 pos;
    private void Awake()
    {
        Audio = GetComponent<AudioManager>();
    }
    /// <summary>
    /// 餌(アシカ)生成
    /// </summary>
    public void Spawn()
    {
        GameObject go = Instantiate(FeedPrefab) as GameObject;
        go.name = go.name.Replace("(Clone)", "");
        //範囲でランダム生成
        float px = Random.Range(-4, 4);
        float py = Random.Range(8, 15);
        //平行移動
        go.transform.position = new Vector3(px, py, 16.1f);
        Vector3 pos = transform.position;
        transform.position = pos;
    }
}
>>>>>>> 4e422a6cfcc53e068f2d1f60f43b9743c7b28367:Killer Whale Project/Assets/ryusuke/Scripts/FeedGenerator.cs
