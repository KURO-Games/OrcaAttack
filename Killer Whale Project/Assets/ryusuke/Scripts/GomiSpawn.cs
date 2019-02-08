using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GomiSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject GomiPrefab;
    [SerializeField]
    AudioManager Audio;
    public Vector3 pos;
    private void Awake()
    {
        Audio = GetComponent<AudioManager>();
    }
    public void Spawn()
    {
        GameObject go = Instantiate(GomiPrefab) as GameObject;
        go.name = go.name.Replace("(Clone)", "");
        float px = Random.Range(8, -6);
        float py = Random.Range(8.5f, 8.5f);
        go.transform.position = new Vector3(px, py, 16.1f);
        this.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        Vector3 pos = transform.position;
        transform.position = pos;
    }
}
