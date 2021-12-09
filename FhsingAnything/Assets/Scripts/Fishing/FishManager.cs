using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    [SerializeField]
    protected int sizeLv;
    [SerializeField]
    protected int hp;
    [SerializeField]
    protected int money;
    protected enum Tier { Common, Normal, Rare, Epic, Unique, Legendary, Special, None };
    [SerializeField]
    protected Tier FishTier = Tier.None;

    protected void Summon()
    {
        if (Input.GetKeyDown(KeyCode.A)/*낚시 성공 조건*/)
        {
            FishTier = (Tier)Random.Range(0, 6);
            sizeLv = Random.Range(-5, 5);
            SetStatus(FishTier, ref hp, ref money);
        }
    }

    private void SetStatus(Tier FishTier, ref int hp, ref int money)
    {
        if (FishTier == Tier.Common)
        {   
            hp = Random.Range(30, 50);
            money = 0 + sizeLv * (int)FishTier;
            Instantiate(GameManager.instance.CommonFishL[Random.Range(0, GameManager.instance.CommonFishL.Count)]);
        }
        if (FishTier == Tier.Normal)
        {
            hp = Random.Range(60, 100);
            money = 100 + sizeLv * (int)FishTier;
            Instantiate(GameManager.instance.NormalFishL[Random.Range(0, GameManager.instance.CommonFishL.Count)]);
        }
        if (FishTier == Tier.Rare)
        {
            hp = Random.Range(120, 170);
            money = 200 + sizeLv * (int)FishTier;
            Instantiate(GameManager.instance.RareFishL[Random.Range(0, GameManager.instance.CommonFishL.Count)]);
        }
        if (FishTier == Tier.Epic)
        {
            hp = Random.Range(150, 200);
            money = 300 + sizeLv * (int)FishTier;
            Instantiate(GameManager.instance.EpicFishL[Random.Range(0, GameManager.instance.CommonFishL.Count)]);
        }
        if (FishTier == Tier.Unique)
        {
            hp = Random.Range(200, 300);
            money = 400 + sizeLv * (int)FishTier;
            Instantiate(GameManager.instance.UniqueFishL[Random.Range(0, GameManager.instance.CommonFishL.Count)]);
        }
        if (FishTier == Tier.Legendary)
        {
            hp = Random.Range(300, 400);
            money = 500 + sizeLv * (int)FishTier;
            Instantiate(GameManager.instance.LegenaryFishL[Random.Range(0, GameManager.instance.CommonFishL.Count)]);
        }
       
        if (FishTier == Tier.Special)
        {
            hp = Random.Range(300, 550);
            money = 600 + sizeLv * (int)FishTier;
            Instantiate(GameManager.instance.SpecialFishL[Random.Range(0, GameManager.instance.CommonFishL.Count)]);
        } 
    }

    public int GetHp()
    {
        return hp;
    }

    public int GetMoney()
    {
        return money;
    }

    public int GetSizeLv()
    {
        return sizeLv;
    }

    public void SetHp(int hp)
    {
        this.hp = hp;
    }

    public void SetMoney(int money)
    {
        this.money = money;
    }

    public void SetSizeLv(int sizeLv)
    {
        this.sizeLv = sizeLv;
    }
}


