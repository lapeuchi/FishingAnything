using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingValue : MonoBehaviour
{
    public int cnt;
    [SerializeField] Item[] findReset;
    void Start()
    {
        Counting();        
    }

    public void Counting()
    {
        for (int i = 0; i < 59; i++)
        {
            if (findReset[i].Find && findReset[i].isFind)
            {
                cnt++;
            }
        }
        GameManager.instance.index_value = cnt;
    }
}
