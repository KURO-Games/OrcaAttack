using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public Text scoreText;
    private int score = 0;

    private void Start()
    {
        this.score = 0;
        SetScore();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "FeedPrefab")
        {
            GameObject.Destroy(other.gameObject);
        }
    }
    public void AddScore ()
    {
        string yourTag = gameObject.tag;
        if(yourTag == "Feed1")
        {
            this.score += 20;
            Debug.Log("ok");
        }
        else if(yourTag == "Feed2")
        {
            this.score += 40;
        }
        SetScore();
	}
    public void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", this.score);
    }
}
