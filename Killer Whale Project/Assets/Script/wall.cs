using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class wall : MonoBehaviour
{
    private GameObject player;
    void Start()
    {
        this.player = GameObject.Find("OrcaPrefab");
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
        player.gameObject.transform.DOMove(
            new Vector3(0, -9, 16.1f), 2.0f);
        //player.transform.position = new Vector3(0, -9, 16.1f);
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
