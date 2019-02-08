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
    public int ScoreSend()
    {
        return score;
    }
}
