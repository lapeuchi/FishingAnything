using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EquipText : MonoBehaviour
{
    [SerializeField] Text[] FR_Equip;
    [SerializeField] Text[] CH_Equip;
    [SerializeField] Text[] BA_Equip;
    void Update()
    {
        EquipCheckUpdate();
    }
    public void EquipCheckUpdate()
    {
        // 낚시대가 특정 상황일 때
        if (GameManager.instance.Fishingrod_state == GameManager.Fishingrod_State.Normal)
        {
            FR_Equip[(int)GameManager.Fishingrod_State.Normal].text = "장착됨";
        }
        if (GameManager.instance.Fishingrod_state != GameManager.Fishingrod_State.Normal)
        {
            FR_Equip[(int)GameManager.Fishingrod_State.Normal].text = "장착";
        }
        if (GameManager.instance.Fishingrod_state == GameManager.Fishingrod_State.Magic)
        {
            FR_Equip[(int)GameManager.Fishingrod_State.Magic].text = "장착됨";
        }
        if (GameManager.instance.Fishingrod_state != GameManager.Fishingrod_State.Magic)
        {
            FR_Equip[(int)GameManager.Fishingrod_State.Magic].text = "장착";
        }
        if (GameManager.instance.Fishingrod_state == GameManager.Fishingrod_State.God)
        {
            FR_Equip[(int)GameManager.Fishingrod_State.God].text = "장착됨";
        }
        if (GameManager.instance.Fishingrod_state != GameManager.Fishingrod_State.God)
        {
            FR_Equip[(int)GameManager.Fishingrod_State.God].text = "장착";
        }

        // 의자가 특정 상태일 때
        if (GameManager.instance.Chair_state == GameManager.Chair_State.Gaming)
        {
            CH_Equip[(int)GameManager.Chair_State.Gaming].text = "장착됨";
        }
        if (GameManager.instance.Chair_state != GameManager.Chair_State.Gaming)
        {
            CH_Equip[(int)GameManager.Chair_State.Gaming].text = "장착";
        }
        if (GameManager.instance.Chair_state == GameManager.Chair_State.Red)
        {
            CH_Equip[(int)GameManager.Chair_State.Red].text = "장착됨";
        }
        if (GameManager.instance.Chair_state != GameManager.Chair_State.Red)
        {
            CH_Equip[(int)GameManager.Chair_State.Red].text = "장착";
        }
        if (GameManager.instance.Chair_state == GameManager.Chair_State.King)
        {
            CH_Equip[(int)GameManager.Chair_State.King].text = "장착됨";
        }
        if (GameManager.instance.Chair_state != GameManager.Chair_State.King)
        {
            CH_Equip[(int)GameManager.Chair_State.King].text = "장착";
        }

        // 미끼가 특정 상황일 떄
        if (GameManager.instance.Bait_state == GameManager.Bait_State.FishBread)
        {
            BA_Equip[(int)GameManager.Bait_State.FishBread].text = "장착됨";
        }
        if (GameManager.instance.Bait_state != GameManager.Bait_State.FishBread)
        {
            BA_Equip[(int)GameManager.Bait_State.FishBread].text = "장착";
        }
        if (GameManager.instance.Bait_state == GameManager.Bait_State.Wasabi)
        {
            BA_Equip[(int)GameManager.Bait_State.Wasabi].text = "장착됨";
        }
        if (GameManager.instance.Bait_state != GameManager.Bait_State.Wasabi)
        {
            BA_Equip[(int)GameManager.Bait_State.Wasabi].text = "장착";
        }
        if (GameManager.instance.Bait_state == GameManager.Bait_State.Soju)
        {
            BA_Equip[(int)GameManager.Bait_State.Soju].text = "장착됨";
        }
        if (GameManager.instance.Bait_state != GameManager.Bait_State.Soju)
        {
            BA_Equip[(int)GameManager.Bait_State.Soju].text = "장착";
        }
    }
}
