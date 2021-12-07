using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject SelectPlaceBackGround;
    public GameObject BlackBackGround;
    public GameObject Bag;
    public GameObject Status;
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
}
