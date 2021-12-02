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
        GameManager.instance.curGameState = GameManager.GameState.Fishing;
        SceneManager.LoadScene("SeaScene");
    }
    public void GoRiver()
    {
        GameManager.instance.curGameState = GameManager.GameState.Fishing;
        SceneManager.LoadScene("RiverScene");
    }
    public void GoArctic()
    {
        GameManager.instance.curGameState = GameManager.GameState.Fishing;
        SceneManager.LoadScene("ArcticScene");
    }
    public void GoBaclocdam()
    {
        GameManager.instance.curGameState = GameManager.GameState.Fishing;
        SceneManager.LoadScene("BaclocdamScene");
    }
    public void GoBaths()
    {
        GameManager.instance.curGameState = GameManager.GameState.Fishing;
        SceneManager.LoadScene("BathsScene");
    }
    public void GoSewer()
    {
        GameManager.instance.curGameState = GameManager.GameState.Fishing;
        SceneManager.LoadScene("SewerScene");
    }
    public void GoWaterFall()
    {
        GameManager.instance.curGameState = GameManager.GameState.Fishing;
        SceneManager.LoadScene("WaterFallScene");
    }
    public void GoFishMarket()
    {
        GameManager.instance.curGameState = GameManager.GameState.Lobby;
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
