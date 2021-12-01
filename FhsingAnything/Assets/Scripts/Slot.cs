using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slot : MonoBehaviour
{
    [SerializeField] Image Image;

    private Item _item;
    public Item item
    {
        get
        { return _item; }
        set
        {
            _item = value;
            if(_item != null)
            {
                Image.sprite = item.itemImage;
                Image.color = new Color(1, 1, 1, 1);
            }
            else
            {
                Image.color = new Color(1, 1, 1, 0);
            }
        }
    }
}
