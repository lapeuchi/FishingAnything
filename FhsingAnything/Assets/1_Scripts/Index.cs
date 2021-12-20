using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Index : MonoBehaviour
{
    private Item _item;
    public GameObject IndexUI;
    public Text Itemname;
    public Text Livename;
    public Text Expli;
    public Text Rare;
    public Image image;
    public GameObject NotFind;
    public Item IndexItem
    {
        get
        { return _item; }
        set
        {
            _item = value;
            if (_item.Find)
            {
                IndexUI.SetActive(true);
                image.sprite = _item.itemImage;
                Rare.text = _item.Rare;
                Itemname.text = _item.itemName;
                Livename.text = _item.live;
                Expli.text = _item.Explanation;
            }
            else
            {
                NotFound();
            }
            
        }
    } 
    private void NotFound()
    {
        NotFind.SetActive(true);
        Invoke("NotFoundOff", 2f);
    }
    private void NotFoundOff()
    {
        NotFind.SetActive(false);

    }
}
