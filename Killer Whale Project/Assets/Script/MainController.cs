using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    int count = 0;
    int max = 5;

    private Vector3 touchStartPos;
    private Vector3 touchEndPos;

    void Start()
    {
        InvokeRepeating("Generate", 10, 10);
    }
    void Generate()
    {
        if (count == max) return;
        float x = Random.Range(0f, 9f);
        float y = 0;
        float z = Random.Range(0f, 9f);
        Vector3 position = new Vector3(x, y, z);
        //Instantiate(prefab, new Vector3);
        count++;
    }

    private void Flick()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            touchStartPos = new Vector3
                (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            touchEndPos = new Vector3
                (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
            GetDirection();
        }
    }

    private void GetDirection()
    {
        float DirectionX = touchEndPos.x - touchStartPos.x;
        float DirectionY = touchEndPos.y - touchStartPos.y;
        string Direction;



        if (Mathf.Abs(DirectionY) < Mathf.Abs(DirectionX))
        {
            if (30 < DirectionX)
            {
                //右フリック
                Direction = "right";
            }
            else if (-30 > DirectionX)
            {
                //左フリック
                Direction = "left";
            }
        }
        else if (Mathf.Abs(DirectionX) < Mathf.Abs(DirectionY))
        {
            if (30 < DirectionY)
            {
                //上フリック
                Direction = "up";
            }
            else if (-30 > DirectionY)
            {
                //下フリック
                Direction = "down";
            }
        }
        else
        {
            //タッチ
            Direction = "touth";
        }
    }



    public void ResultButtonClicked()
    {
        SceneManager.LoadScene("result");
        GameReset();
    }
    private void GameReset()
    {
        
    }
}