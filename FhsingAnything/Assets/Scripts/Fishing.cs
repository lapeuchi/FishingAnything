using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishing : MonoBehaviour
{
    public List<GameObject> SeaList;
    public List<GameObject> RiverList;
    public List<GameObject> SewerList;
    public List<GameObject> ArticleList;
    public List<GameObject> WaterfallList;
    public List<GameObject> BathList;
    public List<GameObject> Backlocdam;

    public List<GameObject> MapList;

    void Start()
    {
        if(GameManager.instance.fishing_Place_State == GameManager.FishingState.Sea)
        {
            Instantiate(MapList[4]);
        }
        if (GameManager.instance.fishing_Place_State == GameManager.FishingState.River)
        {
            Instantiate(MapList[3]);
        }
        if (GameManager.instance.fishing_Place_State == GameManager.FishingState.Sewer)
        {
            Instantiate(MapList[5]);
        }
        if (GameManager.instance.fishing_Place_State == GameManager.FishingState.Arctic)
        {
            Instantiate(MapList[0]);
        }
        if (GameManager.instance.fishing_Place_State == GameManager.FishingState.Waterfall)
        {
            Instantiate(MapList[6]);
        }
        if (GameManager.instance.fishing_Place_State == GameManager.FishingState.Baths)
        {
            Instantiate(MapList[2]);
        }
        if (GameManager.instance.fishing_Place_State == GameManager.FishingState.Baclocdam)
        {
            Instantiate(MapList[1]);
        }


    }
}
