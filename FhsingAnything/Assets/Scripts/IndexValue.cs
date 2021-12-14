using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndexValue : MonoBehaviour
{
    public Text text;

    private void Update()
    {
        text.text = GameManager.instance.index_value.ToString();
    }
}
