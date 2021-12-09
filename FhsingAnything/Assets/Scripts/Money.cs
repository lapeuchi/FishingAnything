using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    private Text moneyUI;
    void Start()
    {
        moneyUI = gameObject.GetComponent<Text>();
        moneyUpdate();
    }
    public void moneyUpdate()
    {
        moneyUI.text = GameManager.instance.money.ToString();
    }
}
