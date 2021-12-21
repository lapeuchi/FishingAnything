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
    public int Money=100000;
    public int Strength=10; //공격력
    public int ComePower=10;    //유인력
    public int Luck=10; // 흥정력
    public float Stamina=10;  // 스테미너(체력)
    public int Intellect=10;    //지식

    [Header("Shop Price")]
    public int Strength_Price =100;
    public int Luck_Price=100;
    public int ComePower_Price=100;
    public int Stamina_Price=100;
    public int Intellect_Price=100;

    public int index_value;

    public enum Fishingrod_State
    {
        Hand,
        Normal
    }
    public Fishingrod_State Fishingrod_state = Fishingrod_State.Hand;
    
    public enum Chair_State
    {
        Squat
    }
    public Chair_State Chair_state = Chair_State.Squat;

    public enum Bait_State
    {
        Pogayri
    }
    public Bait_State Bait_state = Bait_State.Pogayri;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }           
        DontDestroyOnLoad(gameObject);
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Money", GameManager.instance.Money);
        PlayerPrefs.SetInt("Strength", GameManager.instance.Strength);
        PlayerPrefs.SetInt("ComePower", GameManager.instance.ComePower);
        PlayerPrefs.SetInt("Luck", GameManager.instance.Luck);
        PlayerPrefs.SetFloat("Stamina", GameManager.instance.Stamina);
        PlayerPrefs.SetInt("Intellect", GameManager.instance.Intellect);
        PlayerPrefs.SetInt("Strength_Price", GameManager.instance.Strength_Price);
        PlayerPrefs.SetInt("Luck_Price", GameManager.instance.Luck_Price);
        PlayerPrefs.SetInt("ComePower_Price", GameManager.instance.ComePower_Price);
        PlayerPrefs.SetInt("Stamina_Price", GameManager.instance.Stamina_Price);
        PlayerPrefs.SetInt("Intellect_Price", GameManager.instance.Intellect_Price);
    }
}
