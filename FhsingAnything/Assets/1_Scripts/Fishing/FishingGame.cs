using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingGame : MonoBehaviour
{
    public GameObject FishSiluet;

    void Start()
    {
        InvokeRepeating("SummonSiluet", 1f, Random.Range(0.5f, 1.5f));
        InvokeRepeating("SummonSiluet", 1f, Random.Range(0.5f, 1.5f));
    }

    private void Update()
    {

    }

    void SummonSiluet()
    {
        if (FishManager.instance.hp > 0)
        {
            Fishing.instance.gameProcess = -2;
            Instantiate(FishSiluet, new Vector2(0, 0), Quaternion.identity);
            
        }
        else
            Fishing.instance.gameProcess = 3;
    }
}