using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingGame : MonoBehaviour
{
    public GameObject FishSiluet;

    void Start()
    {
        
    }

    private void Update()
    {
        if (FishManager.instance.hp > 0 && Fishing.instance.gameProcess == 3)
            StartCoroutine(SummonSiluet());
    }

    IEnumerator SummonSiluet()
    {
        if (FishManager.instance.hp > 0)
        {
            int i = Random.Range(0, 2);
            if (i == 0)
                StartCoroutine(SummonSiluet());
            Fishing.instance.gameProcess = -2;
            yield return new WaitForSeconds(Random.RandomRange(1f, 2f));
            Instantiate(FishSiluet, new Vector2(0, 0), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(0f, 1.5f));
            StartCoroutine(SummonSiluet());
        }
        else
            Fishing.instance.gameProcess = 3;
    }
}