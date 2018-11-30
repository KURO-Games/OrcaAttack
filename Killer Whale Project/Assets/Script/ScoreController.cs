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
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "FeedPrefab")
        {
            GameObject.Destroy(other.gameObject);
            AddScore();

        }
    }
    public void AddScore ()
    {
        string yourTag = gameObject.tag;
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
    public void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", score);
    }
}
