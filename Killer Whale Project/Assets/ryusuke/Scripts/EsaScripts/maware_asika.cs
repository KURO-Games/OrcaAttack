using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maware_asika : MonoBehaviour {
    Vector3 reverse;
    [SerializeField]
    private float Speed = 2;


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
        reverse.z = 0;

	}
    private void Movement()
    {

        transform.Translate(Speed * Time.deltaTime, 0, 0);

    }
    private void OnCollisionEnter(Collision col)
    {

        Debug.Log(col.gameObject.name);
    
        if (col.gameObject.tag == "wall")// || col.gameObject.tag == "wall2")
        {

            FripX();
        }
    }
    public void FripX()
    {
        reverse = transform.localScale;
        reverse.x *= -1;
        transform.localScale = reverse;
        transform.Translate(Speed * Time.deltaTime, 0, 0);
        Speed = -1 * Speed;
    }
}

//if (col.gameObject.tag == "wall" || col.gameObject.tag == "wall2")
//{
//    GetComponent<Rigidbody>().isKinematic = true;
//}