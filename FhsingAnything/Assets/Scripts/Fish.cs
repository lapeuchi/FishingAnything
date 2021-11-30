using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    //물고기 티어 종류
    protected enum Tier { Common, Normal, Rare, Epic, Unique, Legendary, Special };
    //소환될 물고기의 티어
    Tier FishTier;
    //소환될 물고기의 크기, 평균 크기에서 단계별로 얼마나 큰지 -5 ~ 5단계 로 구성
    protected int size;
    //소환될 물고기의 가격
    protected float price;

    

     private Fish()
     {
        FishTier = (Tier)Random.Range(0, 6);
        size = Random.Range(-5, 5);
        // 물고기 가격 = 크기 * 티어의 절반값
        price = size * (int)FishTier * 0.5f;
     }
}

