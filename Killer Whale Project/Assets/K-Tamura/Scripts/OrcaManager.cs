using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OrcaManager : MonoBehaviour { 


    // Update is called once per frame
    void Update()
    {
        yokoido();
    }
    /// <summary>
    /// 横移動遷移
    /// </summary>
    private void yokoido()
    {/*
        if (Input.GetMouseButtonDown(0))
        {
            playerPos = this.transform.position;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {

            Vector3 prePos = this.transform.position;
            Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - mousePos;
            if (Input.touchSupported)
            {
                diff = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position) - mousePos;
            }

            diff.z = 0.0f;
            this.transform.position = playerPos + diff;

        }
        if (Input.GetMouseButtonUp(0))
        {
            playerPos = Vector3.zero;
            mousePos = Vector3.zero;
        }
        */




        /*
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 position = Input.mousePosition;
                position.z = 0;
                debug.DStringlog(position.x.ToString());
    */
        mouseposition = Input.mousePosition;
        if (xbutton == false)
        {
            //Vector3 touchPosition = touch.position;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                Debug.LogWarning("mouse on click");
                Orca.transform.position = mouselocal;
                firstMousePos = mouseposition;
                Debug.Log("firstMousePos" + firstMousePos);
                Debug.Log("mouseLocal" + mouselocal);
                Debug.Log("orca transform pos" + Orca.transform.position);

            }
            if (Input.GetMouseButton(0))
            {
                worldTouchPosition = Camera.main.ScreenToViewportPoint(mouseposition);
                // mpuseposition.x ;
                //mpuseposition.x *= 5;
                worldTouchPosition.z = 0;
                worldTouchPosition.y = -2.9f;

                //worldTouchPosition.z = 0;
                //mouselocal.y = -2.9f;
                Orca.transform.position = mouselocal;
                Debug.LogWarning("push");
                Debug.Log("mousepos" + mouseposition);
                Debug.Log("World" + worldTouchPosition);
                Debug.Log("mouselocal" + mouselocal);


            }
            if (Input.GetMouseButtonUp(0))
            {
                Debug.LogWarning("mouse Up");
                lastMousePos = mouseposition;
                if (lastMousePos.x > firstMousePos.x)
                {
                    mouselocal.x += worldTouchPosition.x;
                    Debug.LogError("++");

                }
                else if (lastMousePos.x == firstMousePos.x)
                { Debug.LogError("=="); }
                else if (lastMousePos.x < firstMousePos.x)
                {
                    mouselocal.x -= worldTouchPosition.x;
                    Debug.LogError("--");
                }

                GetComponent<Rigidbody>().isKinematic = true;
                Debug.Log("LastMousePos" + lastMousePos);
                Debug.Log("mouseLocal" + mouselocal);
               // xbutton = true;
            }


        }else{
            if(Input.GetMouseButtonDown(0)){
                firstMousePos = Input.mousePosition;

            }
            if(Input.GetMouseButtonUp(0)){
                lastMousePos = Input.mousePosition;
                mousePos.y = firstMousePos.y - lastMousePos.y;
                GetComponent<Rigidbody>().isKinematic = false;
                Orca.GetComponent<Rigidbody>().AddForce(0,20000,2);
            }

        }




        //Debug.Log(worldTouchPosition);
    }



    private void mouseMovDistance()
    {
        mousemovemt = Input.mousePosition;

    }
}

