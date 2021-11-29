using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//물고기 부모클래스
public abstract class Fish : MonoBehaviour
{
    //물고기 티어
    protected enum Tier {Common, Normal, Rare, Epic, Unique, Legend, Special};
    //물고기 종
    protected enum FishSpecies
    { };
    //물고기 크기
    protected int size;
    //물고기 가격
    protected int price;

    public List<GameObject> fishL;

    protected void SetStatus()
    {
        
    }

    protected void SetFish()
    {
        int r = Random.Range(0, 100);
        if(r >= 0 && r <= 20)
        {

        }
    }
}
