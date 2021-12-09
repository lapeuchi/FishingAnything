using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Arctic_Common;
    private GameObject[] Arctic_Normal;
    private GameObject[] Arctic_Rare;
    private GameObject[] Arctic_Epic;
    private GameObject[] Arctic_Unique;
    private GameObject[] Arctic_Legendary;

    private GameObject[] BacLocDam_Common;
    private GameObject[] BacLocDam_Normal;
    private GameObject[] BacLocDam_Rare;
    private GameObject[] BacLocDam_Epic;
    private GameObject[] BacLocDam_Unique;
    private GameObject[] BacLocDam_Legendary;

    private GameObject[] Baths_Common;
    private GameObject[] Baths_Normal;
    private GameObject[] Baths_Rare;
    private GameObject[] Baths_Epic;
    private GameObject[] Baths_Unique;
    private GameObject[] Baths_Legendary;

    private GameObject[] River_Common;
    private GameObject[] River_Normal;
    private GameObject[] River_Rare;
    private GameObject[] River_Epic;
    private GameObject[] River_Unique;
    private GameObject[] River_Legendary;

    private GameObject[] Sea_Common;
    private GameObject[] Sea_Normal;
    private GameObject[] Sea_Rare;
    private GameObject[] Sea_Epic;
    private GameObject[] Sea_Unique;
    private GameObject[] Sea_Legendary;

    private GameObject[] Sewer_Common;
    private GameObject[] Sewer_Normal;
    private GameObject[] Sewer_Rare;
    private GameObject[] Sewer_Epic;
    private GameObject[] Sewer_Unique;
    private GameObject[] Sewer_Legendary;

    private GameObject[] WafallFall_Common;
    private GameObject[] WafallFall_Normal;
    private GameObject[] WafallFall_Rare;
    private GameObject[] WafallFall_Epic;
    private GameObject[] WafallFall_Unique;
    private GameObject[] WafallFall_Legendary;

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


