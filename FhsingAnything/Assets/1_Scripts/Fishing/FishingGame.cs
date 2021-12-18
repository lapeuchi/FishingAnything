using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingGame : MonoBehaviour
{
    public GameObject FishSiluet;

    void Start()
    {
        StartCoroutine(SummonSiluet());
    }

    IEnumerator SummonSiluet()
    {
        if (FishManager.instance.hp > 0)
        {
            yield return new WaitForSeconds(Random.RandomRange(1f, 2f));
            Instantiate(FishSiluet, new Vector2(0, 0), Quaternion.identity);
            StartCoroutine(SummonSiluet());
        }
    }
}