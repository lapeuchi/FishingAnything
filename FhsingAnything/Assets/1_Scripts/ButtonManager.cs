using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject SelectPlaceBackGround;
    public GameObject BlackBackGround;
    public GameObject Bag;
    public GameObject Status;
    public GameObject TaeHwan;
    public GameObject Mather;
    public Text Mather_talk;
    public Text TaeHwan_talk;
    public void Set_state_Sea() 
    {
        GameManager.instance.fishing_Place_State = GameManager.FishingState.Sea;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_River()
    {
        GameManager.instance.fishing_Place_State = GameManager.FishingState.River;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Arctic()
    {
        GameManager.instance.fishing_Place_State = GameManager.FishingState.Arctic;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Baclocdam()
    {
        GameManager.instance.fishing_Place_State = GameManager.FishingState.Baclocdam;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Baths()
    {
        GameManager.instance.fishing_Place_State = GameManager.FishingState.Baths;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Sewer()
    {
        GameManager.instance.fishing_Place_State = GameManager.FishingState.Sewer;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Waterfall()
    {
        GameManager.instance.fishing_Place_State = GameManager.FishingState.Waterfall;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void GoFishMarket()
    {
        SceneManager.LoadScene("FishMarketScene");
    }
    public void GoShop()
    {
        SceneManager.LoadScene("ShopScene");
    }
    public void GoStatus()
    {
        SceneManager.LoadScene("StatusScene");
    }
    public void GoIndex()
    {
        SceneManager.LoadScene("IndexScene");
    }
    public void onPause()       //일시정지 on !
    {
        BlackBackGround.SetActive(true);
        Time.timeScale = 0;
    }

    public void offPause()      //일시정지 해제
    {
        Time.timeScale = 1;
        BlackBackGround.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void SelectPlaceOn()
    {
        SelectPlaceBackGround.SetActive(true);
    }
    public void BagOn()
    {
        if (Bag.active == true)
            Bag.SetActive(false);
        else
        {
            Bag.SetActive(true);
            Status.SetActive(false);
        }
            
    }
    public void StatusOn()
    {
        if (Status.active == true)
            Status.SetActive(false);
        else
        {
            Status.SetActive(true);
            Bag.SetActive(false);
        }
    }
    public void SelectPlaceFalse()
    {
        SelectPlaceBackGround.SetActive(false);
    }
    public void Tae()
    {
        if (TaeHwan.active == true)
            TaeHwan.SetActive(false);
        else
        {
            TaeHwan.SetActive(true);
        }
    }
    public void matherOn()
    {
        if (Mather.active == true)
            Mather.SetActive(false);
        else
        {
            Mather.SetActive(true);
        }
    }
    public void Mathers_talk()
    {
        string[] talk = new string[] {"전복 하나 어디 갔어\n전복 누가 가져갔어", "나미끼는 최고의 노상방뇨 달인이었어","낚시는 기다림의 미학이란다", 
            "난 전복 가져가는 놈이 세상에서 젤 싫어","한 때는 이 전복으로 세상을 재패했었단다","옛날에는 바다에 바?론? 같은게 없었는데 수질오염인가 뭔가 하는게 이렇게 만들었단다"
            ,"원래 목욕탕에서는 낚시가 금지였단다","언젠가는 나미끼 같은 노상방뇨 마스터가 나타날게야","북극에 사는 북극곰 아는감, 옛날에 그 북극곰 50마리랑 저 마린보이 청년이 댄스 배틀을 했었지.."
            ,"유미라고 귀여운 고양이 한마리가 있는데 신기하게도 책 위에서만 있더구나","낚시가 유행을 탄지 30년 정도 지나갔지만 아직까지 레비아탄을 잡은 낚시꾼이 없단다"
        };
        Mather_talk.text = talk[Random.Range(0, talk.Length)];  
    }
    public void TaeHwans_talk()
    {
        string[] talk = new string[] {"비키니는 사랑입니다♡", "여기 온수 수조의 물은 따뜻해..","낚시가 힘들면 장비를 바꿔보자",
            "비키니 볼려고 국가대표 했다","이 수산시장은 역사가 깊어, 옛날에 이곳에서 북극곰 50마리와 댄스 배틀을 벌였었지..","인어는 존재 할려나? 난 몰?루"
            ,"유미는 정말 좋은 상점 주인이지만 협곡에서 만날때는 좀.. 그래..","낚시 마스터가 되고자 모두가 낚시를 하지만 가끔 낚시 마스터에서 포X몬마스터가 되기도 하더라"
            ,"옛날에 내가 봤던 고딩중에 '넥타이의 지배자 이아림'이라고 있었는데 모든 사람의 넥타이를 빼고 다녔었어"};
        TaeHwan_talk.text = talk[Random.Range(0, talk.Length)];
    }
}
