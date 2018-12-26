using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrcaButtonManager : MonoBehaviour {
    public bool buttonPush = false;
    [SerializeField]
    private Text text;
    private GameObject omanege;
    
	// Use this for initialization
	void Start () {
        text.text = "決定";
        omanege = GameObject.Find("OrcaPrefab");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void buttonClick(){
        if (buttonPush == false)
        {
            buttonPush = true;
            text.text = "キャンセル";
            OrcaManager2.orcatate = true;
            OrcaManager2.orcayoko = false;
        }else {
            buttonPush = false;
            text.text = "決定";
            OrcaManager2.orcatate = false;
            OrcaManager2.orcayoko = true;
        }

    }
}
