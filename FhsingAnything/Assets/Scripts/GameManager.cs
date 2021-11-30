using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;

    public enum GameState { Lobby, Fishing, shop, Setting};
    public GameState curGameState = GameState.Lobby;
    
    public List<Fish> fmL;
    public List<GameObject> aL;

    //public List<Item> ItemL;

    public int won;
    public struct item
    {
        //미끼
        int a;
        //낚시대
        int q;
        //의자
        int c;
        //소모품
        int d;
    }

    

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
