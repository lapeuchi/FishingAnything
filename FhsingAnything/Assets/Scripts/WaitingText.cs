using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaitingText : MonoBehaviour
{
    public float time;
    public Text text;
    private int num;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        num = (int)time;
        switch (num)
        {
            case 1:
                {
                    text.text = "세월을 낚는 중.";
                    break;
                }
            case 2:
                {
                    text.text = "세월을 낚는 중..";
                    break;
                }
            case 3:
                {
                    text.text = "세월을 낚는 중...";
                    break;
                }
            case 4:
                {
                    time = 1;
                    break;
                }

        }
    }
}
