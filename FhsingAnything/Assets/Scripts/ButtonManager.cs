using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject SelectPlaceBackGround;
    public GameObject BlackBackGround;

    public void GoSea() 
    {
        SceneManager.LoadScene("SeaScene");
    }
    public void GoRiver()
    {
        SceneManager.LoadScene("RiverScene");
    }
    public void GoArctic()
    {
        SceneManager.LoadScene("ArcticScene");
    }
    public void GoBaclocdam()
    {
        SceneManager.LoadScene("BaclocdamScene");
    }
    public void GoBaths()
    {
        SceneManager.LoadScene("BathsScene");
    }
    public void GoSewer()
    {
        SceneManager.LoadScene("SewerScene");
    }
    public void GoWaterFall()
    {
        SceneManager.LoadScene("WaterFallScene");
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
    public void SelectPlaceFalse()
    {
        SelectPlaceBackGround.SetActive(false);
    }
}
