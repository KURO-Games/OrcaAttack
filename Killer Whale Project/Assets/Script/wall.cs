using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    //private Vector3 target;
    //Vector3 current;
    //Vector3 velocity = Vector3.zero;
    //private float smoothTime = 2f;
    //float time = 1;
    //float startTime;
    //[SerializeField]
    //Vector3 endPos = new Vector3(0,-9,16.1f);
    //[SerializeField]
    //Vector3 startPos;
    private GameObject player;
    void Start()
    {
        this.player = GameObject.Find("OrcaPrefab");
        //startTime = Time.timeSinceLevelLoad;
        //startPos = player.transform.position;
        //Debug.Log(startPos);
        //current = player.transform.position;
        //target = new Vector3(0,-9,16.1f);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //瞬間移動ではなく時間経過で移動するように変更
            Move();
        }
    }
    void Move()
    {
        //var diff = Time.timeSinceLevelLoad - startTime;
        //if(diff > time)
        //{
        //    transform.position = endPos;
        //}
        //var rate = diff / time;
        player.transform.position = new Vector3(0, -9, 16.1f);
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
    void Update()
    {
    }
}
