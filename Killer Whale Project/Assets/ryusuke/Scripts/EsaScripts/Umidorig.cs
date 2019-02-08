using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Umidorig : MonoBehaviour
{
    [SerializeField]
    private float Speed = 2;
    private GameObject player;
    private ScoreController scoreController;
    private HpController Hpcontroller;
    public Randoms randoms;
    void Start()
    {
        this.player = GameObject.Find("OrcaPrefab");
        scoreController = FindObjectOfType<ScoreController>();
        Hpcontroller = FindObjectOfType<HpController>();
        randoms = FindObjectOfType<Randoms>();
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
                    Hpcontroller.CurrentHP(5);
                    //スコア追加
                    scoreController.AddScore(5);
                    //餌生成関数を呼び出し
                    randoms.Generate();
                }
                else
                {
                    Debug.Log("20");
                    //HP回復
                    Hpcontroller.CurrentHP(5);
                    //スコア追加
                    scoreController.AddScore(5);
                    //餌生成関数を呼び出し
                    randoms.Generate();
                }
            }
            Destroy(gameObject);
        }
    }
}
