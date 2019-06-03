using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seiutig : MonoBehaviour
{
    [SerializeField]
    private float Speed = 2;
    private GameObject player;
    private ScoreController scoreController;
    private HpController Hpcontroller;
    private FeedGenerator feedGenerator;
    void Start()
    {
        this.player = GameObject.Find("OrcaPrefab");
        scoreController = FindObjectOfType<ScoreController>();
        Hpcontroller = FindObjectOfType<HpController>();
        feedGenerator = FindObjectOfType<FeedGenerator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (OrcaManager2.orcamodori == false)
            {
                if (transform.position.y < 11)
                {
                    Debug.Log("10");
                    //HP回復
                    Hpcontroller.CurrentHP(30);
                    //スコア追加
                    scoreController.AddScore(30);
                    //餌生成関数を呼び出し
                    feedGenerator.GetComponent<FeedGenerator>().Revival();
                }
                else
                {
                    Debug.Log("20");
                    //HP回復
                    Hpcontroller.CurrentHP(30);
                    //スコア追加
                    scoreController.AddScore(30);
                    //餌生成関数を呼び出し
                    feedGenerator.GetComponent<FeedGenerator>().Revival();
                }
            }
            Destroy(gameObject);
        }
    }
}