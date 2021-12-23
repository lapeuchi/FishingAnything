using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndexReward : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] GameObject reward;
    [SerializeField] GameObject reward_Ten;
    [SerializeField] GameObject reward_TwoTen;
    [SerializeField] GameObject reward_ThreeTen;
    [SerializeField] GameObject reward_FourTen;
    [SerializeField] GameObject reward_FiveTen;
    [SerializeField] GameObject reward_All;
    void Start()
    {
        Reward();    
    }
    private void Reward()
    {
        if (GameManager.instance.index_value >= 10 && !GameManager.instance.isOned[0])
        {
            SoundManager.instance.PlayCT();
            text.text = "도감 10개 채우기 보상!";
            reward.SetActive(true);
            reward_Ten.SetActive(true);
            GameManager.instance.ComePower += 5;
            GameManager.instance.Max_Stamina += 5;
            GameManager.instance.Strength += 5;
            GameManager.instance.Intellect += 5;
            GameManager.instance.Luck += 5;
            GameManager.instance.isOned[0] = true;
        }
        if (GameManager.instance.index_value >= 20 && !GameManager.instance.isOned[1])
        {
            SoundManager.instance.PlayCT();
            text.text = "도감 20개 채우기 보상!";
            reward.SetActive(true);
            reward_TwoTen.SetActive(true);
            GameManager.instance.Money += 10000;
            GameManager.instance.isOned[1] = true;
        }
        if (GameManager.instance.index_value >= 30 && !GameManager.instance.isOned[2])
        {
            SoundManager.instance.PlayCT();
            text.text = "도감 30개 채우기 보상!";
            reward.SetActive(true);
            reward_ThreeTen.SetActive(true);
            GameManager.instance.ComePower += 2;
            GameManager.instance.Max_Stamina += 2;
            GameManager.instance.Strength += 2;
            GameManager.instance.Intellect += 2;
            GameManager.instance.Luck += 2;
            GameManager.instance.Money += 7000;
            GameManager.instance.isOned[2] = true;
        }
        if (GameManager.instance.index_value >= 40 && !GameManager.instance.isOned[3])
        {
            SoundManager.instance.PlayCT();
            text.text = "도감 40개 채우기 보상!";
            reward.SetActive(true);
            reward_FourTen.SetActive(true);
            GameManager.instance.Max_Stamina += 10;
            GameManager.instance.isOned[3] = true;
        }
        if (GameManager.instance.index_value >= 50 && !GameManager.instance.isOned[4])
        {
            SoundManager.instance.PlayCT();
            text.text = "도감 50개 채우기 보상!";
            reward.SetActive(true);
            reward_FiveTen.SetActive(true);
            GameManager.instance.Money += 50000;
            GameManager.instance.isOned[4] = true;
        }
        if (GameManager.instance.index_value == 59 && !GameManager.instance.isOned[5])
        {
            SoundManager.instance.PlayCT();
            text.text = "축하드립니다!";
            reward.SetActive(true);
            reward_All.SetActive(true);
            GameManager.instance.Money += 50000;
            GameManager.instance.isOned[5] = true;
        }
        
        
        
        
        
    }
    public void RewardOff()
    {
        reward.SetActive(false);
        reward_Ten.SetActive(false);
        reward_TwoTen.SetActive(false);
        reward_ThreeTen.SetActive(false);
        reward_FourTen.SetActive(false);
        reward_FiveTen.SetActive(false);
        reward_All.SetActive(false);
    }
}