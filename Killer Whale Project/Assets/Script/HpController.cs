using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HpController : MonoBehaviour {
    //最大値
    [SerializeField]
    public int maxHP = 100;
    //現在値
    [SerializeField]
    public float currentHP;
    HpBarController Hp;
    [SerializeField]
    private GameObject ScoreBoard;
    ScoreBoard scoreboard;
    GameObject image;
    [SerializeField]
    Sprite imageHPmax, imageHP75, imageHP50, imageHP25, imageHP0;
    int HPmax = 100, HP75 = 75, HP50 = 50, HP25 = 25;//Sprite設定



    public Button button;
    private void Awake()
    {
        Hp = GetComponent<HpBarController>();
    }
    private void Start()
    {

        scoreboard = GetComponent<ScoreBoard>();
        button.gameObject.SetActive(false);
        currentHP = maxHP;
    }
    private void Update()
    {
        Hp.HPDown(currentHP,maxHP);

        if (currentHP >= HPmax)
        {
            image.GetComponent<Image>().sprite = imageHPmax;

        }
        else if (currentHP >= HP75)
        {
            image.GetComponent<Image>().sprite = imageHP75;
        }
        else if (currentHP >= HP50)
        {
            image.GetComponent<Image>().sprite = imageHP50;
        }
        else if (currentHP >= HP25)
        {
            image.GetComponent<Image>().sprite = imageHP25;
        }
        else
        {
            image.GetComponent<Image>().sprite = imageHP0;
        }


        if (0 <= currentHP)
        {

            currentHP -= Time.deltaTime * 4;
        }else{
            button.gameObject.SetActive(true);
            OrcaManager2.orcatate = false;
            OrcaManager2.orcayoko = false;
            OrcaManager2.orcamodori = false;
            scoreboard.ScoreBoardMove(0);

        }
    }
    public void CurrentHP(int Heal)
    {
        if (maxHP > currentHP)
        {
            currentHP = currentHP + Heal;
            if (maxHP < currentHP)
            {
                currentHP = maxHP;
            }
        }
    }
}



