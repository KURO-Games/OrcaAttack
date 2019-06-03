using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public Text scoreText;
    public int score;

    private void Start()
    {
        score = 0;
    }
    public void AddScore (int point)
    {
        score = score + point;
    }
    private void Update()
    {

        if (scoreText != null)
        {
            scoreText.text = string.Format("Score:{0}", score);

        }
    }
    public int ScoreSend()
    {
        return score;
    }
}
