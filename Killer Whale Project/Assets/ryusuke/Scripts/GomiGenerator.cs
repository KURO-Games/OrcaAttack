using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GomiGenerator : MonoBehaviour
{
    [SerializeField]
    private float Speed = 2;
    private GameObject player;
    private ScoreController scoreController;
    private HpController Hpcontroller;
    private GomiGenerator gomiGenerator;
    void Start()
    {
        this.player = GameObject.Find("OrcaPrefab");
        scoreController = FindObjectOfType<ScoreController>();
        Hpcontroller = FindObjectOfType<HpController>();
        gomiGenerator = FindObjectOfType<GomiGenerator>();
    }
    //void Movement()
    //{
    //    transform.Translate(1 * Speed * Time.deltaTime, 0, 0);
    //    //画面外で反転
    //    if (transform.position.x <= -7 || transform.position.x >= 7)

    //    {
    //        Speed = -1 * Speed;
    //        Vector3 scale = transform.localScale;
    //        scale.x = -scale.x;
    //        transform.localScale = scale;
    //    }
    //}
    void Update()
    {
        //Movement();
        //当たり判定
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;
        if (d < r1 + r2)
        {
            if (transform.position.y < 30)
            {
                scoreController.AddScore(2);
                Hpcontroller.CurrentHP(-2);
            }
            else
            {
                scoreController.AddScore(2);
                Hpcontroller.CurrentHP(-2);
            }
            //gomiGenerator.Count(1);
            Destroy(gameObject);
        }
    }
}
