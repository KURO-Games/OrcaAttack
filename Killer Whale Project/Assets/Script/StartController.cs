using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{

    public void MainButtonClicked()
    {
        SceneManager.LoadScene("main");
    }

    void Start()
    {

    }
    void Update()
    {

    }
}