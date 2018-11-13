using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultController : MonoBehaviour
{

    public void StartButtonClicked()
    {
        SceneManager.LoadScene("start");
    }

    public void MainButtonClicked()
    {
        SceneManager.LoadScene("main");
        //GetComponent<HpController>().currentHP = GetComponent<HpController>().maxHP;
    }
    void Start()
    {

    }
    void Update()
    {

    }
}