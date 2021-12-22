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
        PlayerPrefs.DeleteAll();
    }

    //게임시작
    public void GameStart()
    {
        GameManager.instance.Load();
        // 다음 씬(1번 씬) 로드. (1 : 수산시장)
        SceneManager.LoadScene(1);     
    }

    
}
