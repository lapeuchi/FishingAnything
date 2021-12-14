using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public int hp;
    public int money;
    public int size;

    public void Start()
    {
        FishManager.instance.SetStatus(FishManager.instance.FishTier, ref hp, ref money, ref size);
        StartCoroutine(Set());
    }

    void Update()
    {
        if (FishManager.instance.isSucess == true) 
        {
            gameObject.SetActive(true);   
        }
    }

    IEnumerator Set()
    {     
        yield return new WaitForSeconds(0.01f);
        gameObject.SetActive(false);
    }
}