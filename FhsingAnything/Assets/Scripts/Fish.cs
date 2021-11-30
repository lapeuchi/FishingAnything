using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fish : MonoBehaviour
{
    protected int sizeLv;
    protected int hp;
    protected int money;
    protected enum Tier { Uncommon, Normal, Rare, Epic, Unique, Legendary, Special, None };
    protected Tier FishTier = Tier.None;
    protected Fish()
    {
        FishTier = (Tier)Random.Range(0, 6);
        sizeLv = Random.Range(-5, 5);
        SetStatus(FishTier, ref hp, ref money);
    }

    private void SetStatus(Tier FishTier, ref int hp, ref int money)
    {
        if (FishTier == Tier.Uncommon)
        {
            hp = Random.Range(30, 50);
        }
        if (FishTier == Tier.Normal)
        {
            hp = Random.Range(60, 100);
        }
        if (FishTier == Tier.Rare)
        {
            hp = Random.Range(120, 170);
        }
        if (FishTier == Tier.Epic)
        {
            hp = Random.Range(150, 200);
        }
        if (FishTier == Tier.Unique)
        {
            hp = Random.Range(200, 300);
        }
        if (FishTier == Tier.Legendary)
        {
            hp = Random.Range(300, 400);
        }
        if (FishTier == Tier.Special)
        {
            hp = Random.Range(300, 550);
        }
    }

    protected virtual void StoryProcess()
    {
        
    }

    protected abstract void Ment();
}
