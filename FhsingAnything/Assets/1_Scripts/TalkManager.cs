using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TalkManager : MonoBehaviour
{

    private void Start()
    {
        InvokeRepeating("Yuumy_talk", 3f, 3f);
    }
    public Text yumy;
    [SerializeField]
    string[] dialogue = new string[] 
    {   
        "좋은 물고기를 찾으면 갖고와량",
        "낚시가 힘들어? 발톱을 써 발톱!",   
        "이거 완전 재밌어~",
        "고기 고기 물고기다~!",
        "나~의~ 고기고기 물고기는 어디 어디 어디에~",
        "계획이 뭐라구? 잠깐! 이건? 생선이다.. 누가.. 생선가졌냐옹?!"
    };

    public void Yuumy_talk()
    {
        yumy.text = dialogue[Random.Range(0, dialogue.Length)]; 
    }
}
