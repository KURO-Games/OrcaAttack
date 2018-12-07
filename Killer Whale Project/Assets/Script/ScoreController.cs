using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public Text scoreText;
    private int score;

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
        scoreText.text = string.Format("Score:{0}", score);
    }
}
