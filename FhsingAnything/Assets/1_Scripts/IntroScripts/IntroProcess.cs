using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroProcess : MonoBehaviour
{
    public Text MainText;   
    public Image BackGroundImage;   //bg
    public Sprite[] BackGroundL; // 0 : 목욕탕 , 1 : 지도 , 2 : 검은화면
    public GameObject Content;

    public float scrollSpeed; //95 당선

    public byte process = 0;

    void Start()
    {
        
    }

    void Update()
    {
        Content.transform.Translate(Vector2.up * Time.deltaTime * scrollSpeed);
        if(process == 0)
        {
            StartCoroutine(FadeIn(BackGroundL[2]));
            process = 1;
        }
    }

    IEnumerator FadeIn(Sprite BackGroundL)
    {
        BackGroundImage.sprite = BackGroundL;
        for (float f = 0f; f <= 1; f += 0.1f)
        {
            Color c = BackGroundImage.color;
            c.a = f;
            BackGroundImage.color = c;
            yield return null;
        }
    }
    IEnumerator FadeOut()
    {
        for (float f = 1f; f >= 0; f -= 0.2f)
        {
            Color c = BackGroundImage.color;
            c.a = f;
            BackGroundImage.color = c;
            yield return null;
        }

    }
}
