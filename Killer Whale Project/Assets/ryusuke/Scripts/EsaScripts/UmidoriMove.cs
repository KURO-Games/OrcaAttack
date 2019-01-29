using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmidoriMove : MonoBehaviour
{
    Vector3 reverse;
    [SerializeField]
    private float Speed = 2f;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        reverse.z = 0;

    }
    private void Movement()
    {
         transform.Translate(1 * Speed * Time.deltaTime, 0, 0);
            //画面外で反転
            if (transform.position.x <= -3.5 || transform.position.x >= 9)

            {
                Speed = -1 * Speed;
                Vector3 scale = transform.localScale;
                scale.x = -scale.x;
                transform.localScale = scale;
            }
        }
    }

//if (col.gameObject.tag == "wall" || col.gameObject.tag == "wall2")
//{
//    GetComponent<Rigidbody>().isKinematic = true;
//}