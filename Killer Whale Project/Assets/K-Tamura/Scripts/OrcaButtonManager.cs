using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrcaButtonManager : MonoBehaviour {
    public bool buttonPush = false;
    [SerializeField]
    private Text text;
	// Use this for initialization
	void Start () {
        text.text = "決定";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void buttonClick(){
        if (buttonPush = false)
        {
            buttonPush = true;
            text.text = "キャンセル";
        }else {
            buttonPush = false;
            text.text = "決定";
        }

    }
}
