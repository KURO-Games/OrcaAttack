using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    [SerializeField]
    private int scene= 1;

    public void MainButtonClicked()
    {
        SceneManager.LoadScene(scene);
        GetComponent<HpController>().currentHP = GetComponent<HpController>().maxHP;
    }

    void Start()
    {

    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MainButtonClicked();
        }
    }
}