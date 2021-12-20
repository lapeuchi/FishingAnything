using System.Collections;
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
    void Start()
    {
        StatusUIUpdate();
    }

    private void StatusUIUpdate()
    {
        Power.text = GameManager.instance.Strength.ToString();
        Luck.text = GameManager.instance.Luck.ToString();
        ComePower.text = GameManager.instance.ComePower.ToString();
        Tired.text = GameManager.instance.Stamina.ToString();
        Bargen.text = GameManager.instance.Intellect.ToString();
    }
}
