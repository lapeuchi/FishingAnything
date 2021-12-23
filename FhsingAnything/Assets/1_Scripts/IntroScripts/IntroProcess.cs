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

    public float chargingTime = 0f;

    public bool ableSkipBG;

    private void Start()
    {
        StartCoroutine(Main());
    }

    public void Update()
    {
        Skip();
    }

    private void FixedUpdate()
    {
        Content.transform.Translate(Vector2.up * Time.deltaTime * scrollSpeed);
    }

    IEnumerator Main()
    {    
        StartCoroutine(FadeIn(BackGroundL[2]));
        yield return new WaitForSeconds(10f);
        FadeOut();
        yield return new WaitUntil(() => ableSkipBG == true);

        StartCoroutine(FadeIn(BackGroundL[0]));
        MainText.color = new Color(180, 255, 0, 255);
        yield return new WaitForSeconds(40f);
        FadeOut();
        yield return new WaitUntil(() => ableSkipBG == true);

        MainText.color = new Color(0, 0, 0, 255);
        StartCoroutine(FadeIn(BackGroundL[1]));
        yield return new WaitForSeconds(50f);

        SoundManager.instance.StopIntro();
        SceneManager.LoadScene("LoginScene");
    }

    IEnumerator FadeIn(Sprite BackGroundL)
    {
        ableSkipBG = false;
        BackGroundImage.sprite = BackGroundL;
        for (float f = 0f; f <= 1; f += 0.1f)
        {
            Color c = BackGroundImage.color;
            c.a = f;
            BackGroundImage.color = c;
            yield return null;
        }
        StopCoroutine(FadeIn(BackGroundL));
        ableSkipBG = true;
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

    void Skip()
    {
        if (Input.anyKey)
        {
            chargingTime += Time.deltaTime;
            if (chargingTime >= 1f)
            {
                SoundManager.instance.StopIntro();
                SceneManager.LoadScene("LoginScene");   
            }
                
        }
        else chargingTime = 0f;
    }
}
