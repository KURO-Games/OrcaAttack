﻿using System.Collections;
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
    HpBarController Hp;

    public Button button;
    private void Awake()
    {
        Hp = GetComponent<HpBarController>();
    }
    private void Start()
    {
        button.gameObject.SetActive(false);
        currentHP = maxHP;
    }
    private void Update()
    {
        Hp.HPDown(currentHP,maxHP);
        if (0 <= currentHP)
        {
            currentHP -= Time.deltaTime * 2;
        }else{
            button.gameObject.SetActive(true);
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
