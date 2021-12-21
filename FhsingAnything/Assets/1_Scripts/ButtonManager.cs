using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject SelectPlaceBackGround;
    public GameObject BlackBackGround;
    public GameObject TaeHwan;
    public GameObject Mather;
    public GameObject IndexUI;
    public GameObject NoMoney;
    public Text Mather_talk;
    public Text TaeHwan_talk;

    public void Set_state_Sea() 
    {
        SoundManager.instance.PlayClickSound();
        GameManager.instance.fishing_Place_State = GameManager.FishingState.Sea;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_River()
    {
        SoundManager.instance.PlayClickSound();
        GameManager.instance.fishing_Place_State = GameManager.FishingState.River;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Arctic()
    {
        SoundManager.instance.PlayClickSound();
        GameManager.instance.fishing_Place_State = GameManager.FishingState.Arctic;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Baclocdam()
    {
        SoundManager.instance.PlayClickSound();
        GameManager.instance.fishing_Place_State = GameManager.FishingState.Baclocdam;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Baths()
    {
        SoundManager.instance.PlayClickSound();
        GameManager.instance.fishing_Place_State = GameManager.FishingState.Baths;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Sewer()
    {
        SoundManager.instance.PlayClickSound();
        GameManager.instance.fishing_Place_State = GameManager.FishingState.Sewer;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Waterfall()
    {
        SoundManager.instance.PlayClickSound();
        GameManager.instance.fishing_Place_State = GameManager.FishingState.Waterfall;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void GoFishMarket()
    {
        SoundManager.instance.PlayClickSound();
        SceneManager.LoadScene("FishMarketScene");
    }
    public void GoShop()
    {
        SoundManager.instance.PlayClickSound();
        SceneManager.LoadScene("ShopScene");
    }
    public void GoStatus()
    {
        SoundManager.instance.PlayClickSound();
        SceneManager.LoadScene("StatusScene");
    }
    public void GoIndex()
    {
        SoundManager.instance.PlayClickSound();
        SceneManager.LoadScene("IndexScene");
    }
    public void onPause()       //일시정지 on !
    {
        SoundManager.instance.PlayClickSound();
        BlackBackGround.SetActive(true);
        Time.timeScale = 0;
    }

    public void offPause()      //일시정지 해제
    {
        SoundManager.instance.PlayClickSound();
        Time.timeScale = 1;
        BlackBackGround.SetActive(false);
    }
    public void ExitGame()
    {
        SoundManager.instance.PlayClickSound();
        Application.Quit();
    }

    public void SelectPlaceOn()
    {
        SoundManager.instance.PlayClickSound();
        SelectPlaceBackGround.SetActive(true);
    }
    public void SelectPlaceFalse()
    {
        SoundManager.instance.PlayClickSound();
        SelectPlaceBackGround.SetActive(false);
    }
    public void Tae()
    {
        SoundManager.instance.PlayClickSound();
        if (TaeHwan.active == true)
            TaeHwan.SetActive(false);
        else
        {
            TaeHwan.SetActive(true);
        }
    }
    public void matherOn()
    {
        SoundManager.instance.PlayClickSound();
        if (Mather.active == true)
            Mather.SetActive(false);
        else
        {
            Mather.SetActive(true);
        }
    }
    public void OnOffIndex()
    {
        SoundManager.instance.PlayClickSound();
        IndexUI.SetActive(false);
    }
    public void Mathers_talk()
    {
        SoundManager.instance.PlayClickSound();
        string[] talk = new string[] {"전복 하나 어디 갔어\n전복 누가 가져갔어", "나미끼는 최고의 노상방뇨 달인이었어","낚시는 기다림의 미학이란다", 
            "난 전복 가져가는 놈이 세상에서 젤 싫어","한 때는 이 전복으로 세상을 재패했었단다","옛날에는 바다에 바?론? 같은게 없었는데 수질오염인가 뭔가 하는게 이렇게 만들었단다"
            ,"원래 목욕탕에서는 낚시가 금지였단다","언젠가는 나미끼 같은 노상방뇨 마스터가 나타날게야","북극에 사는 북극곰 아는감, 옛날에 그 북극곰 50마리랑 저 마린보이 청년이 댄스 배틀을 했었지.."
            ,"유미라고 귀여운 고양이 한마리가 있는데 신기하게도 책 위에서만 있더구나","낚시가 유행을 탄지 30년 정도 지나갔지만 아직까지 레비아탄을 잡은 낚시꾼이 없단다"
        };
        Mather_talk.text = talk[Random.Range(0, talk.Length)];  
    }
    public void TaeHwans_talk()
    {
        SoundManager.instance.PlayClickSound();
        string[] talk = new string[] {"비키니는 사랑입니다♡", "여기 온수 수조의 물은 따뜻해..","낚시가 힘들면 장비를 바꿔보자",
            "비키니 볼려고 국가대표 했다","이 수산시장은 역사가 깊어, 옛날에 이곳에서 북극곰 50마리와 댄스 배틀을 벌였었지..","인어는 존재 할려나? 난 몰?루"
            ,"유미는 정말 좋은 상점 주인이지만 협곡에서 만날때는 좀.. 그래..","낚시 마스터가 되고자 모두가 낚시를 하지만 가끔 낚시 마스터에서 포X몬마스터가 되기도 하더라"
            ,"옛날에 내가 봤던 고딩중에 '넥타이의 지배자 이아림'이라고 있었는데 모든 사람의 넥타이를 빼고 다녔었어"};
        TaeHwan_talk.text = talk[Random.Range(0, talk.Length)];
    }
    public void Buy_Power()
    {
        float changeMoney;
        if(GameManager.instance.Strength_Price > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.Money -= GameManager.instance.Strength_Price;
            changeMoney = (GameManager.instance.Strength_Price * 1.3f);
            GameManager.instance.Strength_Price = (int)changeMoney;
            GameManager.instance.Strength++;
        }
    }
    public void Buy_Luck()
    {
        float changeMoney;
        if (GameManager.instance.Luck_Price > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.Money -= GameManager.instance.Luck_Price;
            changeMoney = (GameManager.instance.Luck_Price * 1.3f);
            GameManager.instance.Luck_Price = (int)changeMoney;
            GameManager.instance.Luck++;
        }
    }
    public void Buy_ComePower()
    {
        float changeMoney;
        if (GameManager.instance.ComePower_Price > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.Money -= GameManager.instance.ComePower_Price;
            changeMoney = (GameManager.instance.ComePower_Price * 1.3f);
            GameManager.instance.ComePower_Price = (int)changeMoney;
            GameManager.instance.ComePower++;
        }
    }
    public void Buy_Stamina()
    {
        float changeMoney;
        if (GameManager.instance.Stamina_Price > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.Money -= GameManager.instance.Stamina_Price;
            changeMoney = (GameManager.instance.Stamina_Price * 1.3f);
            GameManager.instance.Stamina_Price = (int)changeMoney;
            GameManager.instance.Stamina++;
        }
    }
    public void Buy_Intellect()
    {
        float changeMoney;
        if (GameManager.instance.Intellect_Price > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.Money -= GameManager.instance.Intellect_Price;
            changeMoney = (GameManager.instance.Intellect_Price * 1.3f);
            GameManager.instance.Intellect_Price = (int)changeMoney;
            GameManager.instance.Intellect++;
        }
    }
    public void Buy_Normalrod()
    {
        if (GameManager.instance.Intellect_Price > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.Money -= 1000;
            Destroy(gameObject);
        }
    }
    private void NomoneyOff()
    {
        if (NoMoney.active == true)
        {
            NoMoney.SetActive(false);
        } 
    }
    
    public void Unquip_Fishingrod()
    {
        GameManager.instance.Fishingrod_state = GameManager.Fishingrod_State.Hand;
    }
    public void Equip_Fishingrod_Normalrod()
    {
        GameManager.instance.Fishingrod_state = GameManager.Fishingrod_State.Normal;
    }
    public void Unquip_Chair()
    {
        GameManager.instance.Chair_state = GameManager.Chair_State.Squat;
    }
    public void Unquip_Bait()
    {
        GameManager.instance.Bait_state = GameManager.Bait_State.Pogayri;
    }
}
