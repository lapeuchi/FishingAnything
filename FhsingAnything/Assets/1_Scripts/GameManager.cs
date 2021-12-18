using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public enum GameState { Lobby, Fishing, shop, Setting };
    public GameState curGameState = GameState.Lobby;
   
    public List<GameObject> FishList;
    public List<GameObject> CommonFish;
    public List<GameObject> NormalFish;
    public List<GameObject> RareFish;
    public List<GameObject> EpicFish;
    public List<GameObject> UniqueFish;
    public List<GameObject> LegenaryFish;
    public List<GameObject> SpecialFish;

    [SerializeField] public GameObject[] Arctic_Common;
    [SerializeField] public GameObject[] Arctic_Normal;
    [SerializeField] public GameObject[] Arctic_Rare;
    [SerializeField] public GameObject[] Arctic_Epic;
    [SerializeField] public GameObject[] Arctic_Unique;
    [SerializeField] public GameObject[] Arctic_Legendary;

    [SerializeField] public GameObject[] BacLocDam_Common;
    [SerializeField] public GameObject[] BacLocDam_Normal;
    [SerializeField] public GameObject[] BacLocDam_Rare;
    [SerializeField] public GameObject[] BacLocDam_Epic;
    [SerializeField] public GameObject[] BacLocDam_Unique;
    [SerializeField] public GameObject[] BacLocDam_Legendary;

    [SerializeField] public GameObject[] Baths_Common;
    [SerializeField] public GameObject[] Baths_Normal;
    [SerializeField] public GameObject[] Baths_Rare;
    [SerializeField] public GameObject[] Baths_Epic;
    [SerializeField] public GameObject[] Baths_Unique;
    [SerializeField] public GameObject[] Baths_Legendary;

    [SerializeField] public GameObject[] River_Common;
    [SerializeField] public GameObject[] River_Normal;
    [SerializeField] public GameObject[] River_Rare;
    [SerializeField] public GameObject[] River_Epic;
    [SerializeField] public GameObject[] River_Unique;
    [SerializeField] public GameObject[] River_Legendary;

    [SerializeField] public GameObject[] Sea_Common;
    [SerializeField] public GameObject[] Sea_Normal;
    [SerializeField] public GameObject[] Sea_Rare;
    [SerializeField] public GameObject[] Sea_Epic;
    [SerializeField] public GameObject[] Sea_Unique;
    [SerializeField] public GameObject[] Sea_Legendary;

    [SerializeField] public GameObject[] Sewer_Common;
    [SerializeField] public GameObject[] Sewer_Normal;
    [SerializeField] public GameObject[] Sewer_Rare;
    [SerializeField] public GameObject[] Sewer_Epic;
    [SerializeField] public GameObject[] Sewer_Unique;
    [SerializeField] public GameObject[] Sewer_Legendary;

    [SerializeField] public GameObject[] Waterfall_Common;
    [SerializeField] public GameObject[] Waterfall_Normal;
    [SerializeField] public GameObject[] Waterfall_Rare;
    [SerializeField] public GameObject[] Waterfall_Epic;
    [SerializeField] public GameObject[] Waterfall_Unique;
    [SerializeField] public GameObject[] Waterfall_Legendary;

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
    public int money;
    public int index_value = 0;

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

   
}
