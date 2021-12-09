using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public enum GameState { Lobby, Fishing, shop, Setting};
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

    //public List<Item> ItemL;

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
