using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine3 : MonoBehaviour
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
            GameManager.instance.Stamina -= 0.5f;
        }       
    }

    private void OnTriggerEnter2D(Collider2D cd)
    {
        if(!cd.gameObject.CompareTag("FishSiluet"))
        {
            isScanned = true;
        }
    }

    private void OnTriggerExit2D(Collider2D cd)
    {
        if (!cd.gameObject.CompareTag("FishSiluet"))
        {
            isScanned = false;
        }
    }
}
