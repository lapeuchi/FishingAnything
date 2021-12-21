﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusUI : MonoBehaviour
{
    public Text Power;
    public Text Luck;
    public Text ComePower;
    public Text Tired;
    public Text Bargen;

    // Start is called before the first frame update
    void Update()
    {
        StatusUIUpdate();
    }

    private void StatusUIUpdate()
    {
        Power.text = GameManager.instance.Strength.ToString()+"(+"+GameManager.instance.Strength_Equip.ToString()+")";
        Luck.text = GameManager.instance.Luck.ToString();
        ComePower.text = GameManager.instance.ComePower.ToString()+"(+"+GameManager.instance.ComePower_Equip.ToString() + ")";
        Tired.text = GameManager.instance.Stamina.ToString()+"(+" + GameManager.instance.Stamina_Equip.ToString() + ")";
        Bargen.text = GameManager.instance.Intellect.ToString();
    }
}
