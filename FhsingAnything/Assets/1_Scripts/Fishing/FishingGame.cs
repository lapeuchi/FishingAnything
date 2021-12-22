using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingGame : MonoBehaviour
{
    public GameObject FishSiluet;

    void Start()
    {
        InvokeRepeating("SummonSiluet", 1f, Random.Range(0.5f, 1.5f));
        //InvokeRepeating("SummonSiluet", 1f, Random.Range(0.5f, 1.5f));
    }

    private void Update()
    {

    }

    void SummonSiluet()
    {
        if (FishManager.instance.hp > 0 && Fishing.instance.gameProcess == -2 || Fishing.instance.gameProcess == 3)
        {
            Fishing.instance.gameProcess = -2;
            Instantiate(FishSiluet, new Vector2(0, 0), Quaternion.identity);           
        }
        else if(Fishing.instance.gameProcess == -2 && FishManager.instance.hp <= 0)
            Fishing.instance.gameProcess = 3;
    }
}