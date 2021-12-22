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
    [SerializeField] GameObject MaxStamina;

    public Text Message;
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
        GameManager.instance.Save();
        SoundManager.instance.PlayClickSound();
        Application.Quit();
    }

    public void SelectPlaceOn()
    {
        if (GameManager.instance.Stamina <= 0)
            StartCoroutine(Yell("스테미너가 부족해 낚시를 할 수 없습니다."));
        else
        {
            SoundManager.instance.PlayClickSound();
            SelectPlaceBackGround.SetActive(true);
        }
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
        if (GameManager.instance.Strength_Price > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.Money -= GameManager.instance.Strength_Price;
            changeMoney = (GameManager.instance.Strength_Price * 1.1f);
            GameManager.instance.Strength_Price = (int)changeMoney;
            GameManager.instance.Strength++;
            GameManager.instance.Save();
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
            changeMoney = (GameManager.instance.Luck_Price * 1.1f);
            GameManager.instance.Luck_Price = (int)changeMoney;
            GameManager.instance.Luck++;
            GameManager.instance.Save();
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
            changeMoney = (GameManager.instance.ComePower_Price * 1.1f);
            GameManager.instance.ComePower_Price = (int)changeMoney;
            GameManager.instance.ComePower++;
            GameManager.instance.Save();
        }
    }
    public void Buy_Stamina()
    {
        if (70 > GameManager.instance.Money || GameManager.instance.Max_Stamina <= GameManager.instance.Stamina)
        {
            MaxStamina.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {  
            GameManager.instance.Money -= 70;
            GameManager.instance.Stamina += 50;
            if(GameManager.instance.Stamina >= GameManager.instance.Max_Stamina)
            {
                GameManager.instance.Stamina = GameManager.instance.Max_Stamina;
            }
            GameManager.instance.Save();
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
            changeMoney = (GameManager.instance.Intellect_Price * 1.1f);
            GameManager.instance.Intellect_Price = (int)changeMoney;
            GameManager.instance.Intellect++;
            GameManager.instance.Save();
        }
    }
    private void NomoneyOff()
    {
        MaxStamina.SetActive(false);
        NoMoney.SetActive(false);
    }
    // 특정 낚시대를 살 떄
    public void Buy_Normalrod()
    {
        if (1000 > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.isBuy[0] = true;
            GameManager.instance.Money -= 1000;
            Destroy(gameObject);
        }
    }
    public void Buy_magicrod()
    {
        if (10000 > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.isBuy[1] = true;
            GameManager.instance.Money -= 10000;
            Destroy(gameObject);
        }
    }
    public void Buy_Godrod()
    {
        if (55000 > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.isBuy[2] = true;
            GameManager.instance.Money -= 55000;
            Destroy(gameObject);
        }
    }
    // 특정 의자를 구매 할 때
    public void Buy_GamingChair()
    {
        if (850 > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.Max_Stamina = 100 + GameManager.instance.Stamina_Equip;
            GameManager.instance.isBuy[3] = true;
            GameManager.instance.Money -= 850;
            Destroy(gameObject);
        }
    }
    public void Buy_RedChair()
    {
        if (1850 > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.Max_Stamina = 100 + GameManager.instance.Stamina_Equip;
            GameManager.instance.isBuy[4] = true;
            GameManager.instance.Money -= 1850;
            Destroy(gameObject);
        }
    }
    public void Buy_KingChair()
    {
        if (10000 > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.Max_Stamina = 100 + GameManager.instance.Stamina_Equip;
            GameManager.instance.isBuy[5] = true;
            GameManager.instance.Money -= 10000;
            Destroy(gameObject);
        }
    }

    // 특정 미끼를 구매 할 때
    public void Buy_FishBreadBait()
    {
        if (700 > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.isBuy[6] = true;
            GameManager.instance.Money -= 700;
            Destroy(gameObject);
        }
    }
    public void Buy_WasabiBait()
    {
        if (2100 > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.isBuy[7] = true;
            GameManager.instance.Money -= 2100;
            Destroy(gameObject);
        }
    }
    public void Buy_SojuBait()
    {
        if (10000 > GameManager.instance.Money)
        {
            NoMoney.SetActive(true);
            Invoke("NomoneyOff", 2f);
        }
        else
        {
            GameManager.instance.isBuy[8] = true;
            GameManager.instance.Money -= 10000;
            Destroy(gameObject);
        }
    }
    // 특정 낚시대를 장착할 때
    public void Equip_Fishingrod_Normalrod()
    {
        GameManager.instance.Fishingrod_state = GameManager.Fishingrod_State.Normal;
    }
    public void Equip_Fishingrod_Magicrod()
    {
        GameManager.instance.Fishingrod_state = GameManager.Fishingrod_State.Magic;
    }
    public void Equip_Fishingrod_Godrod()
    {
        GameManager.instance.Fishingrod_state = GameManager.Fishingrod_State.God;
    }

    // 특정 의자를 장착할 떄
    public void Equip_Chair_Gamingchair()
    {
        GameManager.instance.Chair_state = GameManager.Chair_State.Gaming;
    }
    public void Equip_Chair_Redchair()
    {
        GameManager.instance.Chair_state = GameManager.Chair_State.Red;
    }
    public void Equip_Chair_Kingchair()
    {
        GameManager.instance.Chair_state = GameManager.Chair_State.King;
    }

    // 특정 미끼를 장착할 때
    public void Equip_Bait_Fishbread()
    {
        GameManager.instance.Bait_state = GameManager.Bait_State.FishBread;
    }
    public void Equip_Bait_Wasabi()
    {
        GameManager.instance.Bait_state = GameManager.Bait_State.Wasabi;
    }
    public void Equip_Bait_Soju()
    {
        GameManager.instance.Bait_state = GameManager.Bait_State.Soju;
    }

    // 장비 해제 할때
    public void Unquip_Fishingrod()
    {
        GameManager.instance.Fishingrod_state = GameManager.Fishingrod_State.Hand;
    }
    
    public void Unquip_Chair()
    {
        GameManager.instance.Chair_state = GameManager.Chair_State.Squat;
    }
    public void Unquip_Bait()
    {
        GameManager.instance.Bait_state = GameManager.Bait_State.Pogayri;
    }

    public IEnumerator Yell(string str)
    {
        Message.color = new Color(255, 210, 23, 255);
        Message.text = str;
        yield return new WaitForSeconds(1f);
        for (float f = 1f; f >= 0; f -= 0.02f)
        {
            Color c = Message.color;
            c.a = f;
            Message.color = c;
            yield return null;
        }
        Message.color = new Color(255, 210, 23, 0);
    }
}
