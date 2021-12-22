using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    //데이터 초기화
    public void ResetData()
    {
        PlayerPrefs.SetInt("isFirst", 0);
        Application.Quit();
    }

    //게임시작
    public void GameStart()
    {
        GameManager.instance.Load();
        // 다음 씬(2번 씬) 로드.
        SceneManager.LoadScene(3);     
    }

    //게임 종료
    public void GameExit()
    {
        Application.Quit();
    }

    
}
