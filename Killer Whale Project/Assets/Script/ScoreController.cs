using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public Text scoreText;
    private int score = 0;

    private void Start()
    {
        score = 0;
        SetScore();
    }
    void OnCollisionEnter (Collision collision)
    {
        string yourTag = collision.gameObject.tag;
        if(yourTag == "Feed1")
        {
            score += 20;
        }
        else if(yourTag == "Feed2")
        {
            score += 40;
        }
        SetScore();
	}
    void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", score);
    }
}
