using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public int hp;
    public int money;
    public int size;

    void Update()
    {
    
    }

    public void Start()
    {
        FishManager.instance.FishTier = (FishManager.Tier)Random.Range(0, 6);
        FishManager.instance.SetStatus(FishManager.instance.FishTier, ref hp, ref money, ref size);
    }
}