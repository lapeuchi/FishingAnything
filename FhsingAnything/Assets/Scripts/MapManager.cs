using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    // 선언
    public GameObject Player;
    void Start()
    {
        Player.transform.position = new Vector2(2.84f , -2.83f);
    }
}
