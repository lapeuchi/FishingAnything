using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isbuy : MonoBehaviour
{
    [SerializeField] GameObject NormalFR;
    [SerializeField] GameObject MagicFR;
    [SerializeField] GameObject GodFR;
    [SerializeField] GameObject GamingCH;
    [SerializeField] GameObject RedCH;
    [SerializeField] GameObject KingCH;
    [SerializeField] GameObject FishBreadBait;
    [SerializeField] GameObject WasabiBait;
    [SerializeField] GameObject SojuBait;
    // Start is called before the first frame update
    void Start()
    {
        BuyCheck();   
    }
    private void BuyCheck()
    {
        if(GameManager.instance.isBuy[0] == true)
        {
            Destroy(NormalFR);
        }
        if (GameManager.instance.isBuy[1] == true)
        {
            Destroy(MagicFR);
        }
        if (GameManager.instance.isBuy[2] == true)
        {
            Destroy(GodFR);
        }
        if (GameManager.instance.isBuy[3] == true)
        {
            Destroy(GamingCH);
        }
        if (GameManager.instance.isBuy[4] == true)
        {
            Destroy(RedCH);
        }
        if (GameManager.instance.isBuy[5] == true)
        {
            Destroy(KingCH);
        }
        if (GameManager.instance.isBuy[6] == true)
        {
            Destroy(FishBreadBait);
        }
        if (GameManager.instance.isBuy[7] == true)
        {
            Destroy(WasabiBait);
        }
        if (GameManager.instance.isBuy[8] == true)
        {
            Destroy(SojuBait);
        }
    }
    
}
