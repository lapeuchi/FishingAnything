using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public bool isFadeIn = false;
    public Image FadeInImage;
    IEnumerator FadeIn()
    {
        isFadeIn = true;
        for (float f = 0f; f <= 1; f += 0.008f)
        {
            Color c = FadeInImage.color;
            c.a = f;
            FadeInImage.color = c;
            yield return null;
        }
        StartCoroutine(FadeOut());
    }
    IEnumerator FadeOut()
    {
        isFadeIn = false;
        for (float f = 1f; f >= 0; f -= 0.008f)
        {
            Color c = FadeInImage.color;
            c.a = f;
            FadeInImage.color = c;
            yield return null;
        }
        FishManager.instance.isSucess = false;
    }

    private void Update()
    {
        if(FishManager.instance.isSucess == true)
        {
            StartCoroutine(FadeIn());           
        }
    }
}
