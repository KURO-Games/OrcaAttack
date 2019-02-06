using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feedg : MonoBehaviour {
    [SerializeField]
    private float Speed = 2;
    private GameObject player;
    private ScoreController scoreController;
    private HpController Hpcontroller;
    public Randoms randoms;
    void Start() {
        this.player = GameObject.Find("OrcaPrefab");
        scoreController = FindObjectOfType<ScoreController>();
        Hpcontroller = FindObjectOfType<HpController>();
        randoms = FindObjectOfType<Randoms>();
    }
    void Movement()
    {
        transform.Translate(1 * Speed * Time.deltaTime, 0, 0);
        //画面外で反転
        if (transform.position.x <= -7 || transform.position.x >=7)

        {
            Speed = -1 * Speed;
            Vector3 scale = transform.localScale;
            scale.x = -scale.x;
            transform.localScale = scale;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(OrcaManager2.orcamodori == false)
            {
                if (transform.position.y < 11)
                {
                    Debug.Log("10");
                    //HP回復
                    Hpcontroller.CurrentHP(5);
                    //スコア追加
                    scoreController.AddScore(10);
                    //餌生成関数を呼び出し
                    randoms.Generate();
                }
                else
                {
                    Debug.Log("20");
                    //HP回復
                    Hpcontroller.CurrentHP(10);
                    //スコア追加
                    scoreController.AddScore(20);
                    //餌生成関数を呼び出し
                    randoms.Generate();
                }
            }
            Destroy(gameObject);
        }
    }
    void Update () {
        Movement();
    }
}
