using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


/// <summary>
/// Score board Controller.
/// </summary>
public class ScoreBoard : MonoBehaviour {
    /// <summary>
    /// The HpController.
    /// </summary>
    HpController hpController;
    /// <summary>
    /// The object score board.
    /// </summary>
    [SerializeField]
    GameObject Object_ScoreBoard;
    ScoreController scoreController;
    [SerializeField]
    GameObject[] Num;
    [SerializeField]
    int OnemoreScene, TitleScene;
    protected int num;
    [SerializeField]
    private Sprite[] numSprite;
    bool end = false;
    [SerializeField]
    GameObject button1, button2;
    // Use this for initialization
    /// <summary>
    /// Start this init.
    /// </summary>
    void Start () {
        hpController = GetComponent<HpController>();
        scoreController = GetComponent<ScoreController>();
	}

    // Update is called once per frame
    /// <summary>
    /// 判定文
    /// </summary>
    void Update()
    {
        if (end == false)
        {
            num = scoreController.ScoreSend();
        }
    }
    /// <summary>
    /// Scores the board move.
    /// </summary>
    /// <param name="mov">0 to <see langword="true"/> and 1 to false</param>
    private void ScoreBoardMove(int mov)
    {
        if (mov == 0)//true
        {
            end = true;
            this.gameObject.GetComponent<RectTransform>().DOLocalMoveY(0,1f)
            .OnComplete(() => {
                for (int i = 0; i <= 120; i++)
                {
                    randomnumber();
                }
                View(num);
                button1.gameObject.SetActive(true);
                button2.gameObject.SetActive(true);
            });
        }
        else if(mov == 1)//false
        {

            this.gameObject.GetComponent<RectTransform>().DOLocalMoveY(-1000, 1f).OnComplete(() => {
                num = 0;
                //ScoreController.score = 0;
                button1.gameObject.SetActive(false);
                button2.gameObject.SetActive(false);
            });
        }

    }
    private int randomrange()
    {
        return Random.Range(0, 9);
    }
    private void randomnumber()
    {
        int random = randomrange();
        View(random);

    }
    void View(int score)
    {
        var digit = score;

        List<int> number = new List<int>();
        while (digit != 0)
        {
            score = digit % 10;
            digit = digit / 10;
            number.Add(score);
        }
        GameObject.Find("num").GetComponent<Image>().sprite = numSprite[number[0]];
        for (int i = 1; i < number.Count; i++)
        {

            RectTransform scoreimage = (RectTransform)Instantiate(GameObject.Find("num")).transform;
            scoreimage.SetParent(this.transform, false);
            scoreimage.localPosition = new Vector2(scoreimage.localPosition.x - scoreimage.sizeDelta.x * i,scoreimage.localPosition.y);
            scoreimage.GetComponent<Image>().sprite = numSprite[number[i]];
        }
    }
    public void OneMore()
    {
        ScoreBoardMove(1);
        
    }
    public void Title()
    {
        SceneManager.LoadScene(TitleScene);
    }

}
