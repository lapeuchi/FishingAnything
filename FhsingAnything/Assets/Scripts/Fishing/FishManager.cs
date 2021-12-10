using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    public static FishManager instance = null;
 
    [SerializeField]
    protected int sizeLv;
    [SerializeField]
    protected int hp;
    [SerializeField]
    protected int money;
    protected enum Tier { Common, Normal, Rare, Epic, Unique, Legendary, Special, None };
    [SerializeField]
    protected Tier FishTier = Tier.None;

    public GameObject[] CommonFishL;
    public GameObject[] NormalFishL;
    public GameObject[] RareFishL;
    public GameObject[] EpicFishL;
    public GameObject[] UniqueFishL;
    public GameObject[] LegenaryFishL;
    public GameObject[] SpecialFishL;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
        SetFishList(GameManager.instance.fishing_Place_State);
    }

    public void Summon()
    {
        //if (Input.GetKeyDown(KeyCode.A)/*낚시 성공 조건*/)
        //{        
            sizeLv = Random.Range(-5, 5);
            SetStatus(FishTier, hp, money);
//        }
    }

    

    private void SetFishList(GameManager.FishingState map)
    {
        //FishTier = (Tier)Random.Range(0, 6);
        if (map == GameManager.FishingState.Arctic)
        {
            CommonFishL = GameManager.instance.Arctic_Common;
            NormalFishL = GameManager.instance.Arctic_Normal;
            RareFishL = GameManager.instance.Arctic_Rare;
            EpicFishL = GameManager.instance.Arctic_Epic;
            UniqueFishL = GameManager.instance.Arctic_Unique;
            LegenaryFishL = GameManager.instance.Arctic_Legendary;
        }
        if (map == GameManager.FishingState.Baclocdam)
        {
            CommonFishL = GameManager.instance.Arctic_Common;
            NormalFishL = GameManager.instance.Arctic_Normal;
            RareFishL = GameManager.instance.Arctic_Rare;
            EpicFishL = GameManager.instance.Arctic_Epic;
            UniqueFishL = GameManager.instance.Arctic_Unique;
            LegenaryFishL = GameManager.instance.Arctic_Legendary;
        }
        if (map == GameManager.FishingState.Baths)
        {
            CommonFishL = GameManager.instance.BacLocDam_Common;
            NormalFishL = GameManager.instance.BacLocDam_Normal;
            RareFishL = GameManager.instance.BacLocDam_Rare;
            EpicFishL = GameManager.instance.BacLocDam_Epic;
            UniqueFishL = GameManager.instance.BacLocDam_Unique;
            LegenaryFishL = GameManager.instance.BacLocDam_Legendary;
        }    
        if (map == GameManager.FishingState.River)
        {
            CommonFishL = GameManager.instance.River_Common;
            NormalFishL = GameManager.instance.River_Normal;
            RareFishL = GameManager.instance.River_Rare;
            EpicFishL = GameManager.instance.River_Epic;
            UniqueFishL = GameManager.instance.River_Unique;
            LegenaryFishL = GameManager.instance.River_Legendary;
        }
        if (map == GameManager.FishingState.Sea)
        {
            CommonFishL = GameManager.instance.Sea_Common;
            NormalFishL = GameManager.instance.Sea_Normal;
            RareFishL = GameManager.instance.Sea_Rare;
            EpicFishL = GameManager.instance.Sea_Epic;
            UniqueFishL = GameManager.instance.Sea_Unique;
            LegenaryFishL = GameManager.instance.Sea_Legendary;
        }
        if (map == GameManager.FishingState.Sewer)
        {
            CommonFishL = GameManager.instance.Sewer_Common;
            NormalFishL = GameManager.instance.Sewer_Normal;
            RareFishL = GameManager.instance.Sewer_Rare;
            EpicFishL = GameManager.instance.Sewer_Epic;
            UniqueFishL = GameManager.instance.Sewer_Unique;
            LegenaryFishL = GameManager.instance.Sewer_Legendary;
        }
        if (map == GameManager.FishingState.Waterfall)
        {
            CommonFishL = GameManager.instance.Waterfall_Common;
            NormalFishL = GameManager.instance.Waterfall_Normal;
            RareFishL = GameManager.instance.Waterfall_Rare;
            EpicFishL = GameManager.instance.Waterfall_Epic;
            UniqueFishL = GameManager.instance.Waterfall_Unique;
            LegenaryFishL = GameManager.instance.Waterfall_Legendary;
        }
    }
    private void SetStatus(Tier FishTier, int hp, int money)
    {
        if (FishTier == Tier.Common)
        {   
            hp = Random.Range(30, 50);
            money = 0 + sizeLv * (int)FishTier;
            Instantiate(CommonFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Normal)
        {
            hp = Random.Range(60, 100);
            money = 100 + sizeLv * (int)FishTier;
            Instantiate(NormalFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Rare)
        {
            hp = Random.Range(120, 170);
            money = 200 + sizeLv * (int)FishTier;
            Instantiate(NormalFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Epic)
        {
            hp = Random.Range(150, 200);
            money = 300 + sizeLv * (int)FishTier;
            Instantiate(EpicFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Unique)
        {
            hp = Random.Range(200, 300);
            money = 400 + sizeLv * (int)FishTier;
            Instantiate(UniqueFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Legendary)
        {
            hp = Random.Range(300, 400);
            money = 500 + sizeLv * (int)FishTier;
            Instantiate(LegenaryFishL[Random.Range(0, CommonFishL.Length)]);
        }
       
        if (FishTier == Tier.Special)
        {
            hp = Random.Range(300, 550);
            money = 600 + sizeLv * (int)FishTier;
            Instantiate(SpecialFishL[Random.Range(0, CommonFishL.Length)]);
        } 
    }
}


