using System.Collections;using System.Collections.Generic;using UnityEngine;using UnityEngine.UI;

public class OrcaManager2 : MonoBehaviour
{
    Vector3 worlddir=new Vector3(0,-5f,16.1f), mouseposition, firsttouch = new Vector3(0, -5f, 16.1f), secondrelease, thr, pos, mod = new Vector3(), point = new Vector3(), orcafirstpos = new Vector3(0, -5f, 16.1f);
    [SerializeField] private GameObject Orca;
    [SerializeField] private float OrcaSpeed = 1f, orcahippari = 100f, modori = 1f * -1;
    [SerializeField] public bool orcayoko, orcatate, orcamodori;
    private Camera cam; bool botton = false;
    public static string Nam;
    [SerializeField]
    private float touchpanel;
    [SerializeField]
    private float OrcaPositionTop, OrcaPositionBottom;
    void Start() { cam = Camera.main; mouseposition = Vector3.zero; worlddir = Vector3.zero; orcayoko = true; orcatate = false; }
    void Update()
    {
        Touchpanel(); Mousehantei(); modoriins();
        //Debug.Log("Y"+orcayoko+" T"+orcatate+" F"+firsttouch+" S"+secondrelease+" W"+worlddir+" M"+mouseposition+" O"+Orca.transform.localPosition);
        if (orcayoko == true && orcatate == false) OrcaYokoIdo();
        if (orcatate == true && orcayoko == false) OrcaTateIdo();
        OrcaPos();

    }
    /// <summary>
    /// Touchpanel this instance.
    /// </summary>
    private void Touchpanel()
    {
        mouseposition = Input.mousePosition;
        if (Input.GetMouseButtonDown(0))
        {
            worlddir = Camera.main.ScreenToWorldPoint(new Vector3(mouseposition.x, mouseposition.y, 16.1f));
            if (worlddir.y <= -13.1) botton = true;
            else botton = false;
        }
        if (Input.GetMouseButton(0)) worlddir = Camera.main.ScreenToWorldPoint(new Vector3(mouseposition.x, mouseposition.y, 16.1f));
        if (Input.GetMouseButtonUp(0)) botton = false;
    }
    /// <summary>
    /// Orca横移動
    /// </summary>
    void OrcaYokoIdo()
    {
        if (Input.GetMouseButton(0))
        {
            if (botton != true)
            {
                //worlddir.y = -9f; 
                Orca.transform.localPosition = new Vector3(worlddir.x, -9f, 16.1f);
            }
        }
    }
    /// <summary>
    /// Orca縦移動
    /// </summary>
    void OrcaTateIdo()
    {
        if (Input.GetMouseButtonUp(0))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(thr.x * orcahippari, thr.y * orcahippari, 0));
        }
    }
    /// <summary>
    /// Mouse取得(Update)
    /// </summary>
    void Mousehantei()
    {
        if (Input.GetMouseButtonDown(0))
        {//各判定mouseのposition(first)
            firsttouch.x = mouseposition.x; firsttouch.y = mouseposition.y; firsttouch.z = 0;
        }
        if (Input.GetMouseButton(0))
        {//各判定mouseのposition(second)
            secondrelease.x = mouseposition.x; secondrelease.y = mouseposition.y; secondrelease.z = 0;
        }
        if (Input.GetMouseButtonUp(0))
        {//各判定mouseのposition_vector3(final)
            thr = firsttouch - secondrelease;
        }
    }
    /// <summary>
    /// オルカ戻り処理
    /// </summary>
    void modoriins()
    {
        pos = Orca.transform.position;
        if (orcamodori == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (pos.y >= -9f)
                {
                    pos.y -= modori; Orca.transform.localPosition = pos;
                }
                else
                {
                    orcayoko = true; orcamodori = false;
                }
            }
        }
    }
    /// <summary>
    /// オルカコライダー
    /// </summary>
    /// <param name="collision">Collision.</param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "orcaWall")
        {
            orcatate = false; orcayoko = false; orcamodori = true;
        }
    }
    /// <summary>
    /// タッチパネル判定
    /// </summary>
    /// 
 /*
    private void TouchpanelCheck()
    {
        if (thr.y <= touchpanel)
        {
            orcatate = true; orcayoko = false;
        }
        else
        {
            orcatate = false; orcayoko = true;
        }
    }
*/

    private void OrcaPos()
    {
        orcafirstpos = Camera.main.ScreenToWorldPoint(new Vector3(0, Input.mousePosition.y, 0));
        Debug.Log(worlddir);
        if (Input.GetMouseButtonDown(0))
        {
            if (orcamodori == false)
            {

                if (worlddir.y >= OrcaPositionTop)
                {
                    orcatate = true; orcayoko = false;
                }
                else
                {
                    orcatate = false; orcayoko = true;
                }
            }
            else orcatate = false;
        }
    }
}

