using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject SelectPlaceBackGround;
    public GameObject BlackBackGround;
    public GameObject Bag;

    public enum FishingState
    {
        Sea,
        River,
        Arctic,
        Baclocdam,
        Baths,
        Sewer,
        Waterfall
    }

    public FishingState State;

    public void Set_state_Sea() 
    {
        State = FishingState.Sea;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_River()
    {
        State = FishingState.River;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Arctic()
    {
        State = FishingState.Arctic;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Baclocdam()
    {
        State = FishingState.Baclocdam;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Baths()
    {
        State = FishingState.Baths;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Sewer()
    {
        State = FishingState.Sewer;
        SceneManager.LoadScene("FishingPlaseScene");
    }
    public void Set_state_Waterfall()
    {
        State = FishingState.Waterfall;
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
            Bag.SetActive(true);
    }
    public void SelectPlaceFalse()
    {
        SelectPlaceBackGround.SetActive(false);
    }
}
