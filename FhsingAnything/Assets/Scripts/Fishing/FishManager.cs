using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    public static FishManager instance = null;
    public enum Tier { Common, Normal, Rare, Epic, Unique, Legendary, Special, None };
    [SerializeField]
    public Tier FishTier = Tier.None;

    private GameObject[] CommonFishL;
    private GameObject[] NormalFishL;
    private GameObject[] RareFishL;
    private GameObject[] EpicFishL;
    private GameObject[] UniqueFishL;
    private GameObject[] LegenaryFishL;
    private GameObject[] SpecialFishL;

    public GameObject fish;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);    
    }

    private void Start()
    {
        SetFishList(GameManager.instance.fishing_Place_State);
    }
    
    public void SetFishList(GameManager.FishingState map)
    {
        
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
    public void SetStatus(Tier FishTier, ref int hp, ref int money, ref int sizeLv)
    {
        sizeLv = Random.Range(-5, 5);
        if (FishTier == Tier.Common)
        {   
            hp = Random.Range(30, 50);
            money = 0 + sizeLv * (int)FishTier;
        }
        if (FishTier == Tier.Normal)
        {
            hp = Random.Range(60, 100);
            money = 100 + sizeLv * (int)FishTier;
        }
        if (FishTier == Tier.Rare)
        {
            hp = Random.Range(120, 170);
            money = 200 + sizeLv * (int)FishTier;
        }
        if (FishTier == Tier.Epic)
        {
            hp = Random.Range(150, 200);
            money = 300 + sizeLv * (int)FishTier;
        }
        if (FishTier == Tier.Unique)
        {
            hp = Random.Range(200, 300);
            money = 400 + sizeLv * (int)FishTier;
        }
        if (FishTier == Tier.Legendary)
        {
            hp = Random.Range(300, 400);
            money = 500 + sizeLv * (int)FishTier;          
        }
       
        if (FishTier == Tier.Special)
        {
            hp = Random.Range(300, 550);
            money = 600 + sizeLv * (int)FishTier;       
        }
        Summon(FishTier);
    }
    public void Summon(Tier FishTier)
    {
        if (FishTier == Tier.Common)
        {
            Instantiate(CommonFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Normal)
        {
            Instantiate(NormalFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Rare)
        {
            Instantiate(NormalFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Epic)
        { 
            Instantiate(EpicFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Unique)
        {
            Instantiate(UniqueFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Legendary)
        {
            Instantiate(LegenaryFishL[Random.Range(0, CommonFishL.Length)]);
        }

        if (FishTier == Tier.Special)
        {
            Instantiate(SpecialFishL[Random.Range(0, CommonFishL.Length)]);
        }
    }
}


