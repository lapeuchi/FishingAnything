using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public void onPause()       //일시정지 on !
    {
        Time.timeScale = 0;
    }

    public void offPause()      //일시정지 해제
    {
        Time.timeScale = 1;    
    }
}
