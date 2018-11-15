
using UnityEngine;
using UnityEngine.UI;

public class Debuglog : MonoBehaviour {
    [SerializeField]
    private Text debuglog;
    private string log = "Debug.Log ¥n ¥n";
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
        debuglog.text = log;
	}
    /// <summary>
    /// string
    /// </summary>
    /// <param name="str">String.</param>
    public void DStringlog(string str){
        log = log+"¥n"+str;
    }
    /// <summary>
    /// /int
    /// </summary>
    /// <param name="i">The index.</param>
    public void Dintlog(int i){
        log = log + "¥n" + i.ToString();
    }
    /// <summary>
    /// Dfloatlog the specified f.
    /// </summary>
    /// <param name="f">F.</param>
    public void Dfloatlog(float f){
        log = log + "¥n" + f.ToString();
    }
    /// <summary>
    /// Ddecimallog the specified d.
    /// </summary>
    /// <param name="d">D.</param>
    public void Ddecimallog(decimal d){
        log = log + "¥n" + d.ToString();
    }
}
