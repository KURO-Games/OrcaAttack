using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    //[SerializeField]
    //Image[] images = new Image[4];

    //[SerializeField]
    //Sprite[] numberSprites = new Sprite[10];
    public GameObject zero;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject timecount;


    // Use this for initialization
    void Start () {
        StartCoroutine(Times());

    }

    public IEnumerator Times()
    {
        yield return new WaitForSeconds(6f);
        timecount.transform.position = new Vector3(-3.5f, -1, 0);
        Debug.Log(timecount.transform.position);
        six.transform.Translate(-5, 3.5f, -16);
        zero.transform.Translate(-4, 3.5f, 16);
        yield return new WaitForSeconds(3f);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
