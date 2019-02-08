using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randoms : MonoBehaviour
{
    public FeedGenerator feedGenerator;
    public UmidoriSpawn umidoriSpawn;
    public SeiutiSpawn seiutiSpawn;
    public GomiSpawn gomiSpawn;
    public GomiSpawn2 gomiSpawn2;
    public int GarbageCounter = 0;

    public void Generate()
    {
        int x = Random.Range(1, 10000);

        if (x <= 3000)
        {
            //差し替え用
            feedGenerator.Spawn();
            Debug.Log("餌1\n" + x);
        }
        else if (3000 < x && x <= 6000)
        {
            //差し替え用
            umidoriSpawn.Spawn();
            Debug.Log("餌2\n" + x);
        }
        else if (6000 < x && x <= 9000)
        {
            //差し替え用
            seiutiSpawn.Spawn();
            Debug.Log("餌3\n" + x);
        }
        else if (9000 < x && x <= 9700 && GarbageCounter <= 3)
        {
            GarbageCounter++;
            gomiSpawn.Spawn();
            Debug.Log("ゴミ\n" + x + "\n" + GarbageCounter);
        }
        else if (9700 < x && x <= 10000 && GarbageCounter <= 3)
        {
            GarbageCounter++;
            gomiSpawn2.Spawn();
            Debug.Log("ゴミ\n" + x + "\n" + GarbageCounter);
        }
        else
        {
            feedGenerator.Spawn();
        }
    }
    private void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            Generate();
        }
    }
}
