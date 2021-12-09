using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public enum GameState { Lobby, Fishing, shop, Setting };
    public GameState curGameState = GameState.Lobby;

    public List<GameObject> CommonFish;
    public List<GameObject> NormalFish;
    public List<GameObject> RareFish;
    public List<GameObject> EpicFish;
    public List<GameObject> UniqueFish;
    public List<GameObject> LegenaryFish;
    public List<GameObject> SpecialFish;

    public List<GameObject> FishList;
    public List<GameObject> CommonFishL;
    public List<GameObject> NormalFishL;
    public List<GameObject> RareFishL;
    public List<GameObject> EpicFishL;
    public List<GameObject> UniqueFishL;
    public List<GameObject> LegenaryFishL;
    public List<GameObject> SpecialFishL;

    [SerializeField] private GameObject[] Arctic_Common;
    [SerializeField] private GameObject[] Arctic_Normal;
    [SerializeField] private GameObject[] Arctic_Rare;
    [SerializeField] private GameObject[] Arctic_Epic;
    [SerializeField] private GameObject[] Arctic_Unique;
    [SerializeField] private GameObject[] Arctic_Legendary;

    [SerializeField] private GameObject[] BacLocDam_Common;
    [SerializeField] private GameObject[] BacLocDam_Normal;
    [SerializeField] private GameObject[] BacLocDam_Rare;
    [SerializeField] private GameObject[] BacLocDam_Epic;
    [SerializeField] private GameObject[] BacLocDam_Unique;
    [SerializeField] private GameObject[] BacLocDam_Legendary;

    [SerializeField] private GameObject[] Baths_Common;
    [SerializeField] private GameObject[] Baths_Normal;
    [SerializeField] private GameObject[] Baths_Rare;
    [SerializeField] private GameObject[] Baths_Epic;
    [SerializeField] private GameObject[] Baths_Unique;
    [SerializeField] private GameObject[] Baths_Legendary;

    [SerializeField] private GameObject[] River_Common;
    [SerializeField] private GameObject[] River_Normal;
    [SerializeField] private GameObject[] River_Rare;
    [SerializeField] private GameObject[] River_Epic;
    [SerializeField] private GameObject[] River_Unique;
    [SerializeField] private GameObject[] River_Legendary;

    [SerializeField] private GameObject[] Sea_Common;
    [SerializeField] private GameObject[] Sea_Normal;
    [SerializeField] private GameObject[] Sea_Rare;
    [SerializeField] private GameObject[] Sea_Epic;
    [SerializeField] private GameObject[] Sea_Unique;
    [SerializeField] private GameObject[] Sea_Legendary;

    [SerializeField] private GameObject[] Sewer_Common;
    [SerializeField] private GameObject[] Sewer_Normal;
    [SerializeField] private GameObject[] Sewer_Rare;
    [SerializeField] private GameObject[] Sewer_Epic;
    [SerializeField] private GameObject[] Sewer_Unique;
    [SerializeField] private GameObject[] Sewer_Legendary;

    [SerializeField] private GameObject[] WafallFall_Common;
    [SerializeField] private GameObject[] WafallFall_Normal;
    [SerializeField] private GameObject[] WafallFall_Rare;
    [SerializeField] private GameObject[] WafallFall_Epic;
    [SerializeField] private GameObject[] WafallFall_Unique;
    [SerializeField] private GameObject[] WafallFall_Legendary;

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
