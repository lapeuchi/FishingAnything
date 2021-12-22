using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItmeFindReset : MonoBehaviour
{
    private Item _item;
    [SerializeField] Item[] findReset;
    public void findResetOn()
    {
        for (int i = 0; i < 59; i++)
        {
            findReset[i].Find = false;
            findReset[i].isFind = false;
        }
    }
}
