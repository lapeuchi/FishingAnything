using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    //사용자 데이터를 새로 저장하거나 저장된 데이터를 읽어 사용자의 입력과 일치하는지 검사하게 하고 싶다.

    //사용자 아이디 변수
    public InputField nick;
    public InputField password;

    //검사 택스트 변수
    public Text notify;
    void Start()
    {
        notify.text = "";
    }

    void Update()
    {
        
    }
    
    //닉네임(아이디) 저장 함수
    public void SaveUserData()
    {
        // 만일 입력 검사에 문제가 있으면 함수를 종료한다.
        if(!CheckInput(nick.text, password.text))
        {
            return;
        }

        //사용자의 아이디는 키(key)로 패스워드를 값(value)로 설정해 저장한다.
        PlayerPrefs.SetString(nick.text, password.text);

        //만일 시스템이 저장돼 있는 아이디가 없다면...
        if (!PlayerPrefs.HasKey(nick.text))
        {
            //사용자의 아이디는 키(key)로 패스워드를 값(value)으로 설정해 저장한다.
            PlayerPrefs.SetString(nick.text, password.text);
            notify.text = "아이디 생성이 완료됐습니다.";
        }
        //그렇지 않으면, 이미 존재한다는 메세지 출력
        else
        {
            notify.text = "이미 존재하는 닉네임 입니다.";
        }
    }

    //아이디와 패스워드 저장 함수
    public void CheckUserData()
    {
        //만일 입력 검사에 문제가 있으면 함수 종료
        if(!CheckInput(nick.text, password.text))
        {
            return;
        }

        // 사용자가 입력한 아이디를 키로 사용해 시스템에 저장된 값을 불러온다.
        string pass = PlayerPrefs.GetString(nick.text);

        // 만일, 사용자가 입력한 패스워드와 시스템에서 불러온 값을 비교해서 동일하다면...
        if(password.text == pass)
        {
            // 다음 씬(1번 씬) 로드. (1 : 수산시장)
            SceneManager.LoadScene(1);
        }
        // 그렇지 않고 두 데이터의 값이 다르면, 불일치 메세지 출력
        else
        {
            notify.text = "입력하신 닉네임과 패스워드가 일치하지 않습니다.";
        }
    }

    //입력 완료 확인 함수
    bool CheckInput(string nick, string pwd)
    {
        //만일 닉네임과 패스워드 입력란이 하나라도 비어 있으면 사용자 정보 입력 요구
        if(nick == "" || pwd == "")
        {
            notify.text = "아이디 또는 패스워드를 입력해주세요";
            return false;
        }
        // 입력이 비어 있지 않으면 true 반환
        else
        {
            return true;
        }
    }
}
