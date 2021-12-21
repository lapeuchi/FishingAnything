using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public bool isScanned = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isScanned == false && Input.anyKeyDown)
        {
            GameManager.instance.Stamina -= 1f;
            Fishing.instance.PlayerHpBar.value = GameManager.instance.Stamina / Fishing.instance.PlayerMaxHp;
        }       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!other.gameObject.CompareTag("FishSiluet"))
        {
            isScanned = true;
        }
        else isScanned = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("FishSiluet"))
        {
            isScanned = false;
        }
    }
}
