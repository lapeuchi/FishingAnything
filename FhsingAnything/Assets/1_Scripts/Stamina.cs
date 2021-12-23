using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        gameObject.GetComponent<Text>().text = "피로도:" + GameManager.instance.Stamina + "/" + GameManager.instance.Max_Stamina;               
    }
}
