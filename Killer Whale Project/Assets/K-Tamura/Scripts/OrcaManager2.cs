using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcaManager2 : MonoBehaviour {
    Ray ray;
    Vector3 worlddir;
    Vector3 firsttouch, secondrelease,thr;
    [SerializeField]
    private GameObject Orca;
    [SerializeField]
    private float OrcaSpeed=1,orcahippari=1;
    [SerializeField]
    bool orcayoko=false, orcatate=false;
    // Use this for initialization
    void Start () {
        worlddir = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        Ra();
        Mousehantei();
        Debug.Log(firsttouch+" "+secondrelease);
        if(orcayoko==true&&orcatate==false){
            worlddir.y = 0;
            OrcaYokoIdo();
            
        }
        if(orcatate==true&&orcayoko==false){
            OrcaTateIdo();
        }

	}
    /// <summary>
    /// Ray取得(Update)
    /// </summary>
    void Ra(){
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        worlddir = ray.direction;
        worlddir *= OrcaSpeed;
        worlddir.z = 0;
    }
    /// <summary>
    /// Orca横移動
    /// </summary>
    void OrcaYokoIdo(){
        if(Input.GetMouseButton(0))
        Orca.transform.position = worlddir;
    }
    /// <summary>
    /// Orca縦移動
    /// </summary>
    void OrcaTateIdo(){
        if(Input.GetMouseButtonUp(0)){
            GetComponent<Rigidbody>().AddForce(new Vector3(thr.x*orcahippari,thr.y*orcahippari,0));
        }
    }
    /// <summary>
    /// Mouse取得(Update)
    /// </summary>
    void Mousehantei(){
        if(Input.GetMouseButtonDown(0)){
            firsttouch = worlddir;

        }
        if(Input.GetMouseButton(0)){
            secondrelease = worlddir;


        }
        if(Input.GetMouseButtonUp(0)){
            thr = firsttouch-secondrelease;

        }
    }
}
