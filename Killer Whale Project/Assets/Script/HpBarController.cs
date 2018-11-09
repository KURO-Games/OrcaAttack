using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class HpBarController : MonoBehaviour {

    public GameObject Green;

    void Start (){
        Green = GameObject.Find("Green");
    }

    public void HPDown(float current,int max)
    {
        Green.GetComponent<Image>().fillAmount = current / max; 
    }
}


