using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishing : MonoBehaviour
{
    
    private void Awake()
    {
        GameManager.instance.curGameState = GameManager.GameState.Fishing;
     
    }
    void Start()
    {
    
    }

    void Update()
    {
        
    }
}
