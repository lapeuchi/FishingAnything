using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingGame : MonoBehaviour
{
    public GameObject FishSiluet;

    void Start()
    {
        InvokeRepeating("Summon", 0.5f, Random.RandomRange(1f, 2f));
    }

    void Summon()
    {
        Instantiate(FishSiluet, transform.parent);
    }

    void Update()
    {
       
    }
}
