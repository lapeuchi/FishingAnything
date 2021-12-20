using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    public static FishManager instance = null;
    public enum Tier { Common, Normal, Rare, Epic, Unique, Legendary, Special, None };
    [SerializeField]
    public Tier FishTier = Tier.None;

    public GameObject[] CommonFishL;
    public GameObject[] NormalFishL;
    public GameObject[] RareFishL;
    public GameObject[] EpicFishL;
    public GameObject[] UniqueFishL;
    public GameObject[] LegenaryFishL;
    public GameObject[] SpecialFishL;   //ㅅㅂ

    public int hp;
    public int size;
    public int money;

    public bool isSucess;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);    
    }

    private void Start()
    {
        isSucess = false;
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
            hp = Random.Range(50, 100);
            money = 0 + sizeLv * (int)FishTier;
        }
        if (FishTier == Tier.Normal)
        {
            hp = Random.Range(80, 130);
            money = 100 + sizeLv * (int)FishTier;
        }
        if (FishTier == Tier.Rare)
        {
            hp = Random.Range(70, 160);
            money = 200 + sizeLv * (int)FishTier;
        }
        if (FishTier == Tier.Epic)
        {
            hp = Random.Range(120, 200);
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
        this.hp = hp;
        this.money = money;
        this.size = sizeLv;
    }
    public void Summon(Tier FishTier)
    {
        Debug.Log(CommonFishL.Length + "\n" + NormalFishL.Length + "\n" + RareFishL.Length + "\n" + EpicFishL.Length + "\n"
            + UniqueFishL.Length + "\n" + LegenaryFishL.Length);
        if (FishTier == Tier.Common)
        {
            if (CommonFishL.Length == 1)
                Instantiate(CommonFishL[0]);
            else
                Instantiate(CommonFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Normal)
        {
            if (NormalFishL.Length == 1)
                Instantiate(NormalFishL[0]);
            else
                Instantiate(NormalFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Rare)
        {
            if (RareFishL.Length == 1)
                Instantiate(RareFishL[0]);
            else
                Instantiate(RareFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Epic)
        {
            if (EpicFishL.Length == 1)
                Instantiate(EpicFishL[0]);
            else
                Instantiate(EpicFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Unique)
        {
            if (UniqueFishL.Length == 1)
                Instantiate(UniqueFishL[0]);
            else
                Instantiate(UniqueFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Legendary)
        {
            if (LegenaryFishL.Length == 1)
                Instantiate(LegenaryFishL[0]);
            else
            Instantiate(LegenaryFishL[Random.Range(0, CommonFishL.Length)]);
        }
        if (FishTier == Tier.Special)
        {
            if (SpecialFishL.Length == 1)
                Instantiate(SpecialFishL[0]);
            else
                Instantiate(SpecialFishL[Random.Range(0, CommonFishL.Length)]);
        }
    }
}


