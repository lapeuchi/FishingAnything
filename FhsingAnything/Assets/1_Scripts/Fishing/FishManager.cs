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

    public float hp;
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
            CommonFishL = GameManager.instance.BacLocDam_Common;
            NormalFishL = GameManager.instance.BacLocDam_Normal;
            RareFishL = GameManager.instance.BacLocDam_Rare;
            EpicFishL = GameManager.instance.BacLocDam_Epic;
            UniqueFishL = GameManager.instance.BacLocDam_Unique;
            LegenaryFishL = GameManager.instance.BacLocDam_Legendary;
        }
        if (map == GameManager.FishingState.Baths)
        {
            CommonFishL = GameManager.instance.Baths_Common;
            NormalFishL = GameManager.instance.Baths_Normal;
            RareFishL = GameManager.instance.Baths_Rare;
            EpicFishL = GameManager.instance.Baths_Epic;
            UniqueFishL = GameManager.instance.Baths_Unique;
            LegenaryFishL = GameManager.instance.Baths_Legendary;
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
    public void SetStatus(Tier FishTier, ref float hp, ref int money, ref int sizeLv)
    {
        sizeLv = Random.Range(1, 5);
        if (FishTier == Tier.Common)
        {   
            hp = Random.Range(100, 200);
            money = 10 + sizeLv * (int)FishTier+1;
        }
        if (FishTier == Tier.Normal)
        {
            hp = Random.Range(200, 400);
            money = 100 + sizeLv * (int)FishTier+1;
        }
        if (FishTier == Tier.Rare)
        {
            hp = Random.Range(400, 700);
            money = 200 + sizeLv * (int)FishTier+1;
        }
        if (FishTier == Tier.Epic)
        {
            hp = Random.Range(700, 1100);
            money = 300 + sizeLv * (int)FishTier+1;
        }
        if (FishTier == Tier.Unique)
        {
            hp = Random.Range(1100, 1600);
            money = 400 + sizeLv * (int)FishTier+1;
        }
        if (FishTier == Tier.Legendary)
        {
            hp = Random.Range(1600, 2200);
            money = 500 + sizeLv * (int)FishTier+1;          
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

    public Tier RandTier()
    {
        float i = Random.Range(0f, 101f);
        //if (i <= 49f)
        //    return Tier.Common;
        //else if (i <= 71f)
        //    return Tier.Normal;
        //else if (i <= 86f)
        //    return Tier.Rare;
        //else if (i <= 91f)
        //    return Tier.Epic;
        //else if (i <= 95f)
        //    return Tier.Unique;
        //else if (i <= 101f)
        //    return Tier.Legendary;
        //else return Tier.Common;
        if (i <= 49f)
            return Tier.Common;
        else if (i <= 71f)
            return Tier.Normal;
        else if (i <= 86f)
            return Tier.Rare;
        else if (i <= 91f)
            return Tier.Epic;
        else if (i <= 95f)
            return Tier.Unique;
        else if (i <= 101f)
            return Tier.Legendary;
        else return Tier.Common;
    }

    public void Summon(Tier FishTier)
    {
        Debug.Log("\n" + CommonFishL.Length + "\n" + NormalFishL.Length + "\n" + RareFishL.Length + "\n" + EpicFishL.Length + "\n"
            + UniqueFishL.Length + "\n" + LegenaryFishL.Length);
        if (FishTier == Tier.Common)
        {
            if (CommonFishL.Length == 1)
                Instantiate(CommonFishL[0]);
            else if (CommonFishL.Length == 0)
                Summon(RandTier());
            else
                Instantiate(CommonFishL[Random.Range(0, CommonFishL.Length)],new Vector2(0,1.4f),transform.rotation);
        }
        if (FishTier == Tier.Normal)
        {
            if (NormalFishL.Length == 1)
                Instantiate(NormalFishL[0]);
            else if (NormalFishL.Length == 0)
                Summon(RandTier());
            else
                Instantiate(NormalFishL[Random.Range(0, NormalFishL.Length)], new Vector2(0, 1.4f), transform.rotation);
        }
        if (FishTier == Tier.Rare)
        {
            if (RareFishL.Length == 1)
                Instantiate(RareFishL[0]);
            else if (RareFishL.Length == 0)
                Summon(RandTier());
            else
                Instantiate(RareFishL[Random.Range(0, RareFishL.Length)], new Vector2(0, 1.4f), transform.rotation);
        }
        if (FishTier == Tier.Epic)
        {
            if (EpicFishL.Length == 1)
                Instantiate(EpicFishL[0]);
            else if (EpicFishL.Length == 0)
                Summon(RandTier());
            else
                Instantiate(EpicFishL[Random.Range(0, EpicFishL.Length)], new Vector2(0, 1.4f), transform.rotation);
        }
        if (FishTier == Tier.Unique)
        {
            if (UniqueFishL.Length == 1)
                Instantiate(UniqueFishL[0]);
            else if (UniqueFishL.Length == 0)
                Summon(RandTier());
            else
                Instantiate(UniqueFishL[Random.Range(0, UniqueFishL.Length)], new Vector2(0, 1.4f), transform.rotation);
        }
        if (FishTier == Tier.Legendary)
        {
            if (LegenaryFishL.Length == 1)
                Instantiate(LegenaryFishL[0]);
            else if (LegenaryFishL.Length == 0)
                Summon(RandTier());
            else
                Instantiate(LegenaryFishL[Random.Range(0, LegenaryFishL.Length)], new Vector2(0, 1.4f), transform.rotation);
        }
        if (FishTier == Tier.Special)
        {
            if (SpecialFishL.Length == 1)
                Instantiate(SpecialFishL[0]);
            else if (SpecialFishL.Length == 0)
                Summon(RandTier());
            else
                Instantiate(SpecialFishL[Random.Range(0, SpecialFishL.Length)], new Vector2(0, 1.4f), transform.rotation);
        }
    }
}


