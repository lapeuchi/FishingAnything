using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    public enum GameState 
    {   
        Lobby,
        IntroStory,
        FishMarket,
        Fishing,
        Shop,
        Index,
        Option
    }

    public GameState curState;


    void Start()
    {
        curState = GameState.Lobby;
    }
    void Update()
    {
        
    }
}
