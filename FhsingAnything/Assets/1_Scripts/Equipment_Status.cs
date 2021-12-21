using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equipment_Status : MonoBehaviour
{
    [Header("낚시대 UI 가져오기")]
    public Image FishingRod_Image;
    public Text FishingRod_Name;
    public Text FishingRod_Explanation_UI;

    [Header("의자 UI 가져오기")]
    public Image Chair_Image;
    public Text Chair_Name;
    public Text Chair_Explanation_UI;

    [Header("미끼 UI 가져오기")]
    public Image Bait_Image;
    public Text Bait_Name;
    public Text Bait_Explanation_UI;

    [Header("낚시대 정보")]
    public Sprite[] FishingRod_Sprites;
    public string[] FishingRod_Names;
    public string[] FishingRod_Explanation;
    public int[] FishingRod_Power;

    [Header("의자 정보")]
    public Sprite[] Chair_Sprites;
    public string[] Chair_Names;
    public string[] Chair_Explanation;
    public int[] Chair_Power;

    [Header("미끼 정보")]
    public Sprite[] Bait_Sprites;
    public string[] Bait_Names;
    public string[] Bait_Explanation;
    public int[] Bait_Power;

    void Start()
    {
        StatusUIUpdate();
    }

    public void StatusUIUpdate()
    {
        // 낚시대가 특정 상태일 때
        if(GameManager.instance.Fishingrod_state == GameManager.Fishingrod_State.Hand)
        {
            FishingRod_Image.sprite = FishingRod_Sprites[(int)GameManager.Fishingrod_State.Hand];
            FishingRod_Name.text = FishingRod_Names[(int)GameManager.Fishingrod_State.Hand];
            FishingRod_Explanation_UI.text = FishingRod_Explanation[(int)GameManager.Fishingrod_State.Hand];
            GameManager.instance.Strength_Equip = FishingRod_Power[(int)GameManager.Fishingrod_State.Hand];
        }
        if (GameManager.instance.Fishingrod_state == GameManager.Fishingrod_State.Normal)
        {
            FishingRod_Image.sprite = FishingRod_Sprites[(int)GameManager.Fishingrod_State.Normal];
            FishingRod_Name.text = FishingRod_Names[(int)GameManager.Fishingrod_State.Normal];
            FishingRod_Explanation_UI.text = FishingRod_Explanation[(int)GameManager.Fishingrod_State.Normal];
            GameManager.instance.Strength_Equip = FishingRod_Power[(int)GameManager.Fishingrod_State.Normal];
        }
        if (GameManager.instance.Fishingrod_state == GameManager.Fishingrod_State.Magic)
        {
            FishingRod_Image.sprite = FishingRod_Sprites[(int)GameManager.Fishingrod_State.Magic];
            FishingRod_Name.text = FishingRod_Names[(int)GameManager.Fishingrod_State.Magic];
            FishingRod_Explanation_UI.text = FishingRod_Explanation[(int)GameManager.Fishingrod_State.Magic];
            GameManager.instance.Strength_Equip = FishingRod_Power[(int)GameManager.Fishingrod_State.Magic];
        }
        if (GameManager.instance.Fishingrod_state == GameManager.Fishingrod_State.God)
        {
            FishingRod_Image.sprite = FishingRod_Sprites[(int)GameManager.Fishingrod_State.God];
            FishingRod_Name.text = FishingRod_Names[(int)GameManager.Fishingrod_State.God];
            FishingRod_Explanation_UI.text = FishingRod_Explanation[(int)GameManager.Fishingrod_State.God];
            GameManager.instance.Strength_Equip = FishingRod_Power[(int)GameManager.Fishingrod_State.God];
        }

        // 의자가 특정 상태일 때
        if (GameManager.instance.Chair_state == GameManager.Chair_State.Squat)
        {
            Chair_Image.sprite = Chair_Sprites[(int)GameManager.Chair_State.Squat];
            Chair_Name.text = Chair_Names[(int)GameManager.Chair_State.Squat];
            Chair_Explanation_UI.text = Chair_Explanation[(int)GameManager.Chair_State.Squat];
            GameManager.instance.Stamina_Equip = Chair_Power[(int)GameManager.Chair_State.Squat];
        }
        if (GameManager.instance.Chair_state == GameManager.Chair_State.Gaming)
        {
            Chair_Image.sprite = Chair_Sprites[(int)GameManager.Chair_State.Gaming];
            Chair_Name.text = Chair_Names[(int)GameManager.Chair_State.Gaming];
            Chair_Explanation_UI.text = Chair_Explanation[(int)GameManager.Chair_State.Gaming];
            GameManager.instance.Stamina_Equip = Chair_Power[(int)GameManager.Chair_State.Gaming];
        }
        if (GameManager.instance.Chair_state == GameManager.Chair_State.Red)
        {
            Chair_Image.sprite = Chair_Sprites[(int)GameManager.Chair_State.Red];
            Chair_Name.text = Chair_Names[(int)GameManager.Chair_State.Gaming];
            Chair_Explanation_UI.text = Chair_Explanation[(int)GameManager.Chair_State.Red];
            GameManager.instance.Stamina_Equip = Chair_Power[(int)GameManager.Chair_State.Red];
        }
        if (GameManager.instance.Chair_state == GameManager.Chair_State.King)
        {
            Chair_Image.sprite = Chair_Sprites[(int)GameManager.Chair_State.King];
            Chair_Name.text = Chair_Names[(int)GameManager.Chair_State.King];
            Chair_Explanation_UI.text = Chair_Explanation[(int)GameManager.Chair_State.King];
            GameManager.instance.Stamina_Equip = Chair_Power[(int)GameManager.Chair_State.King];
        }
        // 미끼가 특정 상태일 때
        if (GameManager.instance.Bait_state == GameManager.Bait_State.FishBread)
        {
            Bait_Image.sprite = Bait_Sprites[(int)GameManager.Bait_State.FishBread];
            Bait_Name.text = Bait_Names[(int)GameManager.Bait_State.FishBread];
            Bait_Explanation_UI.text = Bait_Explanation[(int)GameManager.Bait_State.FishBread];
            GameManager.instance.ComePower_Equip = Bait_Power[(int)GameManager.Bait_State.FishBread];
        }
        if (GameManager.instance.Bait_state == GameManager.Bait_State.FishBread)
        {
            Bait_Image.sprite = Bait_Sprites[(int)GameManager.Bait_State.FishBread];
            Bait_Name.text = Bait_Names[(int)GameManager.Bait_State.FishBread];
            Bait_Explanation_UI.text = Bait_Explanation[(int)GameManager.Bait_State.FishBread];
            GameManager.instance.ComePower_Equip = Bait_Power[(int)GameManager.Bait_State.FishBread];
        }
        if (GameManager.instance.Bait_state == GameManager.Bait_State.Wasabi)
        {
            Bait_Image.sprite = Bait_Sprites[(int)GameManager.Bait_State.Wasabi];
            Bait_Name.text = Bait_Names[(int)GameManager.Bait_State.Wasabi];
            Bait_Explanation_UI.text = Bait_Explanation[(int)GameManager.Bait_State.Wasabi];
            GameManager.instance.ComePower_Equip = Bait_Power[(int)GameManager.Bait_State.Wasabi];
        }
        if (GameManager.instance.Bait_state == GameManager.Bait_State.Soju)
        {
            Bait_Image.sprite = Bait_Sprites[(int)GameManager.Bait_State.Soju];
            Bait_Name.text = Bait_Names[(int)GameManager.Bait_State.Soju];
            Bait_Explanation_UI.text = Bait_Explanation[(int)GameManager.Bait_State.Soju];
            GameManager.instance.ComePower_Equip = Bait_Power[(int)GameManager.Bait_State.Soju];
        }
    }


}
