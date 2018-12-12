using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maware2 : MonoBehaviour
{
    Vector3 reverse;
    [SerializeField]
    private float Speed = 2;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        

    }
    private void Movement()
    {

        transform.Translate(-1 * Speed * Time.deltaTime, 0, 0);

    }
    private void OnCollisionEnter(Collision col)
    {
        //if (col.gameObject.tag == "wall" || col.gameObject.tag == "wall2")
        //{
        //    GetComponent<Rigidbody>().isKinematic = true;
        //}



        if (col.gameObject.tag == "wall" || col.gameObject.tag == "wall2")
        {

            reverse = transform.localScale;
            reverse.x *= -1;
            transform.localScale = reverse;
            transform.Translate(-1 * Speed * Time.deltaTime, 0, 0);
            Speed = -1 * Speed;
        }
    }
}
