using System.Collections;using System.Collections.Generic;using UnityEngine;using UnityEngine.Apple;using UnityEngine.UI;

public class OrcaManager2 : MonoBehaviour {
    Vector3 worlddir,mouseposition,firsttouch, secondrelease,thr, point = new Vector3();
    [SerializeField]private GameObject Orca;
    [SerializeField]private float OrcaSpeed=1f,orcahippari=100f;
    [SerializeField]public static bool orcayoko, orcatate;
    private Camera cam; bool botton=false;
    public static string Nam;
    void Start () {cam = Camera.main;mouseposition = Vector3.zero;worlddir = Vector3.zero;orcayoko = true;orcatate = false;}
    void Update () { Touchpanel();Mousehantei();
        //Debug.Log("Y"+orcayoko+" T"+orcatate+" F"+firsttouch+" S"+secondrelease+" W"+worlddir+" M"+mouseposition+" O"+Orca.transform.localPosition);
        if (orcayoko == true && orcatate == false)OrcaYokoIdo();
        if (orcatate == true && orcayoko == false)OrcaTateIdo();
    }
    /// <summary>
    /// Touchpanel this instance.
    /// </summary>
    private void Touchpanel()
    {mouseposition = Input.mousePosition;
    if (Input.GetMouseButtonDown(0))
        { worlddir = Camera.main.ScreenToWorldPoint(new Vector3(mouseposition.x, mouseposition.y, 16.1f));
            if (worlddir.y <= -13.1) botton = true;
            else botton = false;
        }
        if (Input.GetMouseButton(0))worlddir = Camera.main.ScreenToWorldPoint(new Vector3(mouseposition.x, mouseposition.y, 16.1f));
        if(Input.GetMouseButtonUp(0))botton = false;
    }
    /// <summary>
    /// Orca横移動
    /// </summary>
    void OrcaYokoIdo(){if (Input.GetMouseButton(0)){if (botton != true){worlddir.y = -9f;Orca.transform.localPosition = worlddir;}}}
    /// <summary>
    /// Orca縦移動
    /// </summary>
    void OrcaTateIdo(){if (Input.GetMouseButtonUp(0)){GetComponent<Rigidbody>().AddForce(new Vector3(thr.x * orcahippari, thr.y * orcahippari, 0));}}
    /// <summary>
    /// Mouse取得(Update)
    /// </summary>
    void Mousehantei(){
        if(Input.GetMouseButtonDown(0)){//各判定mouseのposition(first)
            firsttouch.x = mouseposition.x;firsttouch.y = mouseposition.y;firsttouch.z = 0;}
        if(Input.GetMouseButton(0)){//各判定mouseのposition(second)
            secondrelease.x = mouseposition.x;secondrelease.y = mouseposition.y;secondrelease.z = 0;}
        if(Input.GetMouseButtonUp(0)){//各判定mouseのposition_vector3(final)
            thr = firsttouch - secondrelease;}
    }
}
