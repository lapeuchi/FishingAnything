using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatutsPrice : MonoBehaviour
{
    public Text PowerPrice;
    public Text LuckPrice;
    public Text ComepowerPrice;
    public Text TriedPrice;
    public Text BargenPrice;
    void Start()
    {
        moneyUpdate();
    }
    void Update()
    {
        moneyUpdate();
    }
    public void moneyUpdate()
    {
        PowerPrice.text = GameManager.instance.Strength_Price.ToString() + "$";
        LuckPrice.text = GameManager.instance.Luck_Price.ToString() + "$";
        ComepowerPrice.text = GameManager.instance.ComePower_Price.ToString() + "$";
        TriedPrice.text = GameManager.instance.Stamina_Price.ToString() + "$";
        BargenPrice.text = GameManager.instance.Intellect_Price.ToString() + "$";
    }
}
