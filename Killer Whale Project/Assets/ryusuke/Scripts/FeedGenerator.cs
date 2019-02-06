using System.Collections;
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
