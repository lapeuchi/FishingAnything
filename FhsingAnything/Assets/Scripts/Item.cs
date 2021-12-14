using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public string itemName;
    public string live;
    public int money;
    public string Explanation;
    public Sprite itemImage;
    public Sprite Notfound;
    public bool Find;
    public bool isFind = false;
}
