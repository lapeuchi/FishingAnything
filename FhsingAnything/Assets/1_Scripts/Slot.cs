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
            if(_item != null && _item.Find)
            {
                Image.sprite = item.itemImage;
                Image.color = new Color(1, 1, 1, 1);
                
                if (_item.Find && !_item.isFind)
                {
                    _item.isFind = true; 
                }
            }
            else
            {
                Image.sprite = item.Notfound;
                Image.color = new Color(1, 1, 1, 1);
            }
        }
    }
}
