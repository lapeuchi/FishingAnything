using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexReward : MonoBehaviour
{
    [SerializeField] GameObject reward;
    [SerializeField] GameObject reward_Ten;
    [SerializeField] GameObject reward_TwoTen;
    [SerializeField] GameObject reward_ThreeTen;
    [SerializeField] GameObject reward_FourTen;
    [SerializeField] GameObject reward_FiveTen;
    [SerializeField] bool[] isOned; 
    private void TenReward()
    {
        if(GameManager.instance.index_value == 10 && !isOned[0])
        {
            reward.SetActive(true);
            reward_Ten.SetActive(true);
            isOned[0] = true;
        }
        if (GameManager.instance.index_value == 20 && !isOned[1])
        {
            reward.SetActive(true);
            reward_TwoTen.SetActive(true);
            isOned[1] = true;
        }
        if (GameManager.instance.index_value == 30 && !isOned[2])
        {
            reward.SetActive(true);
            reward_ThreeTen.SetActive(true);
            isOned[1] = true;
        }
        if (GameManager.instance.index_value == 20 && !isOned[1])
        {
            reward.SetActive(true);
            reward_TwoTen.SetActive(true);
            isOned[1] = true;
        }
        if (GameManager.instance.index_value == 20 && !isOned[1])
        {
            reward.SetActive(true);
            reward_TwoTen.SetActive(true);
            isOned[1] = true;
        }
    }
}