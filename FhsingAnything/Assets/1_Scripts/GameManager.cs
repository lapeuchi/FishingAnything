using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public string USER;
    public enum GameState { Lobby, Fishing, shop, Setting };
    public GameState curGameState = GameState.Lobby;
    [Header("Arctic")]
    public GameObject[] Arctic_Common;
    public GameObject[] Arctic_Normal;
    public GameObject[] Arctic_Rare;
    public GameObject[] Arctic_Epic;
    public GameObject[] Arctic_Unique;
    public GameObject[] Arctic_Legendary;
    [Header("BacLocDam")]
    public GameObject[] BacLocDam_Common;
    public GameObject[] BacLocDam_Normal;
    public GameObject[] BacLocDam_Rare;
    public GameObject[] BacLocDam_Epic;
    public GameObject[] BacLocDam_Unique;
    public GameObject[] BacLocDam_Legendary;
    [Header("Baths")]
    public GameObject[] Baths_Common;
    public GameObject[] Baths_Normal;
    public GameObject[] Baths_Rare;
    public GameObject[] Baths_Epic;
    public GameObject[] Baths_Unique;
    public GameObject[] Baths_Legendary;
    [Header("River")]
    public GameObject[] River_Common;
    public GameObject[] River_Normal;
    public GameObject[] River_Rare;
    public GameObject[] River_Epic;
    public GameObject[] River_Unique;
    public GameObject[] River_Legendary;
    [Header("Sea")]
    public GameObject[] Sea_Common;
    public GameObject[] Sea_Normal;
    public GameObject[] Sea_Rare;
    public GameObject[] Sea_Epic;
    public GameObject[] Sea_Unique;
    public GameObject[] Sea_Legendary;
    [Header("Sewer")]
    public GameObject[] Sewer_Common;
    public GameObject[] Sewer_Normal;
    public GameObject[] Sewer_Rare;
    public GameObject[] Sewer_Epic;
    public GameObject[] Sewer_Unique;
    public GameObject[] Sewer_Legendary;
    [Header("Waterfall")]
    public GameObject[] Waterfall_Common;
    public GameObject[] Waterfall_Normal;
    public GameObject[] Waterfall_Rare;
    public GameObject[] Waterfall_Epic;
    public GameObject[] Waterfall_Unique;
    public GameObject[] Waterfall_Legendary;
    [Header("Item")]
    public Item[] itemL;
    public enum FishingState
    {
        Sea,
        River,
        Arctic,
        Baclocdam,
        Baths,
        Sewer,
        Waterfall,
        None
    }
    public FishingState fishing_Place_State;

    [Header("Player Status")]
    public int Money;
    public int Strength;
    public int ComePower;
    public int Luck;
    public int Stamina;
    public int Intellect;
    public int Strength_Equip;
    public int ComePower_Equip;
    public int Stamina_Equip;

    public int Strength_Price;
    public int Luck_Price;
    public int ComePower_Price;
    public int Stamina_Price;
    public int Intellect_Price;

    public int index_value;
    public enum Fishingrod_State
    {
        Hand,
        Normal,
        Magic,
        God
    }
    public Fishingrod_State Fishingrod_state = Fishingrod_State.Hand;
    
    public enum Chair_State
    {
        Squat,
        Gaming,
        Red,
        King
    }
    public Chair_State Chair_state = Chair_State.Squat;
    
    public enum Bait_State
    {
        Pogayri,
        FishBread,
        Wasabi,
        Soju
    }
    public Bait_State Bait_state = Bait_State.Pogayri;

    void Awake()
    {
        //PlayerPrefs.DeleteAll();
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }           
        DontDestroyOnLoad(gameObject);    
        
        if(PlayerPrefs.GetInt("isFirst") == 0)
        {
            SetNewbie();  
        }
    }
    
    public void Save()
    {
        PlayerPrefs.SetInt("Money", GameManager.instance.Money);
        PlayerPrefs.SetInt("Strength", GameManager.instance.Strength);
        PlayerPrefs.SetInt("ComePower", GameManager.instance.ComePower);
        PlayerPrefs.SetInt("Luck", GameManager.instance.Luck);
        PlayerPrefs.SetInt("Stamina", GameManager.instance.Stamina);
        PlayerPrefs.SetInt("Intellect", GameManager.instance.Intellect);

        PlayerPrefs.SetInt("Strength_Price", GameManager.instance.Strength_Price);
        PlayerPrefs.SetInt("Luck_Price", GameManager.instance.Luck_Price);
        PlayerPrefs.SetInt("ComePower_Price", GameManager.instance.ComePower_Price);
        PlayerPrefs.SetInt("Stamina_Price", GameManager.instance.Stamina_Price);
        PlayerPrefs.SetInt("Intellect_Price", GameManager.instance.Intellect_Price);
    }

    public void Load()
    {
        GameManager.instance.Money = PlayerPrefs.GetInt("Money");
        GameManager.instance.Strength = PlayerPrefs.GetInt("Strength");
        GameManager.instance.ComePower = PlayerPrefs.GetInt("ComePower");
        GameManager.instance.Luck = PlayerPrefs.GetInt("Luck");
        GameManager.instance.Stamina = PlayerPrefs.GetInt("Stamina");
        GameManager.instance.Intellect = PlayerPrefs.GetInt("Intellect");
        GameManager.instance.Strength_Price = PlayerPrefs.GetInt("Strength_Price");
        GameManager.instance.Luck_Price = PlayerPrefs.GetInt("Luck_Price");
        GameManager.instance.ComePower_Price = PlayerPrefs.GetInt("ComePower_Price");
        GameManager.instance.Stamina_Price = PlayerPrefs.GetInt("Stamina_Price");
        GameManager.instance.Intellect_Price = PlayerPrefs.GetInt("Intellect_Price");
    }
    public void SetNewbie()
    {
        PlayerPrefs.SetInt("isFirst", 1);
        GameManager.instance.Money = 100;
        GameManager.instance.Strength = 10;
        GameManager.instance.ComePower = 10;
        GameManager.instance.Luck = 10;
        GameManager.instance.Stamina = 30;
        GameManager.instance.Intellect = 10;
        GameManager.instance.Strength_Equip = 0;
        GameManager.instance.ComePower_Equip = 0;
        GameManager.instance.Stamina_Equip = 0;

        GameManager.instance.Strength_Price = 100;
        GameManager.instance.Luck_Price = 100;
        GameManager.instance.ComePower_Price = 100;
        GameManager.instance.Stamina_Price = 100;
        GameManager.instance.Intellect_Price = 100;
        GameManager.instance.Save();
    }
}