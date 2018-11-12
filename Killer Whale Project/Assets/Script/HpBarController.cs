using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class HpBarController : MonoBehaviour {

    public Button button;
    public Slider _slider;
    //public GameObject _FeedPrefab;

    void Start (){
        button.gameObject.SetActive(false);
        //_FeedPrefab.gameObject.SetActive(true);
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
	}

    float _hp = 1f;
	public void Update () {
        //_hp -= 0.00167f;//10秒
        //_hp -= 0.000833f;//20秒
        //_hp -= 0.000556f;//30秒
        _hp -= 0.000333f;//50秒
        if(_hp < 0)
        {
            //hpが0を下回ったらボタンを表示
            button.gameObject.SetActive(true);
            _slider.gameObject.SetActive(false);
            //_FeedPrefab.gameObject.SetActive(false);
        }
        _slider.value = _hp;
	}
}


