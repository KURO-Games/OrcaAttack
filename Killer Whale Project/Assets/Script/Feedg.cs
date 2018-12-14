using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feedg : MonoBehaviour {
    [SerializeField]
    private float Speed = 2;

    GameObject player;
    ScoreController script;
    // Use this for initialization
    void Start () {
        this.player = GameObject.Find("player");
        script = gameObject.GetComponent<ScoreController>();
    }
	
	// Update is called once per frame
	void Update () {

        transform.Translate(1 * Speed * Time.deltaTime, 0, 0);
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;
        if (d < r1 + r2)
        {
            FindObjectOfType<ScoreController>().AddScore();
            FindObjectOfType<HpController>().CurrentHP(20);
            Destroy(gameObject);
        }
    }
}
