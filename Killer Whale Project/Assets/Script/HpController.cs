using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpController : MonoBehaviour {
    //最大値
    [SerializeField]
    public int maxHP = 100;
    //現在値
    [SerializeField]
    public float currentHP;
    GameObject Hp;

    public Button button;
    private void Start()
    {
        button.gameObject.SetActive(false);
        Hp = GameObject.Find("GameObject"); 
    }

    private void Update()
    {
        Hp.GetComponent<HpBarController>().HPDown(currentHP,maxHP);
    }

    private void FixedUpdate()
    {
        if (0 <= currentHP)
        {
            currentHP = maxHP - Time.time * 50;
        }
        else
        {
            button.gameObject.SetActive(true);
        }
    }
}
