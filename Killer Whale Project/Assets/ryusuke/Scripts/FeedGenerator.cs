using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject FeedPrefab;
    private float span = 5.0f;
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
            float py = Random.Range(8, 15);
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
        for(int i = 0; i < 8; i++)
        {
            delta = span + 1;
            Spawn();
            counter = 0;
        }
    }
    public void Revival()
    {
        counter--;
        Invoke("F",0.5f);
    }
    private void F()
    {
        delta = span + 1;
        Spawn();
    }
    void Update()
    {
        Spawn();
        if(counter == -8)
        {
            Start();
        }
    }
}
