﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fishing : MonoBehaviour
{
    public static Fishing instance = null;
    public List<GameObject> SeaList;
    public List<GameObject> RiverList;
    public List<GameObject> SewerList;
    public List<GameObject> ArticleList;
    public List<GameObject> WaterfallList;
    public List<GameObject> BathList;
    public List<GameObject> Backlocdam;
    public List<GameObject> MapList;

    [SerializeField] private GameObject FishingButton;

    private bool isFishing = false;
    private float time = 0.0f;
    public short gameProcess = -1;

    [SerializeField] private GameObject Sign_Image;
    [SerializeField] private Text Waiting_Text;
    [SerializeField] private GameObject Water;
    [SerializeField] private GameObject Water2; // It used when FishSiluet's 'isGaming' is true
    [SerializeField] public GameObject FishSiluet;

    [SerializeField] private Slider FishHpBar;
    int MaxHp;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        Waiting_Text.text = "";
        SetMap();
    }

    private void SetMap()
    {
        if (GameManager.instance.fishing_Place_State == GameManager.FishingState.Sea)
        {
            Instantiate(MapList[4]);
        }
        if (GameManager.instance.fishing_Place_State == GameManager.FishingState.River)
        {
            Instantiate(MapList[3]);
        }
        if (GameManager.instance.fishing_Place_State == GameManager.FishingState.Sewer)
        {
            Instantiate(MapList[5]);
        }
        if (GameManager.instance.fishing_Place_State == GameManager.FishingState.Arctic)
        {
            Instantiate(MapList[0]);
        }
        if (GameManager.instance.fishing_Place_State == GameManager.FishingState.Waterfall)
        {
            Instantiate(MapList[6]);
        }
        if (GameManager.instance.fishing_Place_State == GameManager.FishingState.Baths)
        {
            Instantiate(MapList[2]);
        }
        if (GameManager.instance.fishing_Place_State == GameManager.FishingState.Baclocdam)
        {
            Instantiate(MapList[1]);
        }
    }

    void Update()
    {
        FishHpBar.value = (float)MaxHp / (float)FishManager.instance.hp;
        if (isFishing == true)
        {
            StartCoroutine(FishSign());

            isFishing = false;
        }

        if (FishSiluet.GetComponent<FishSiluet>().isTrigger && Input.anyKeyDown)
        {
            Debug.Log("isTrigger = true");
            if (gameProcess == 1)
            {
                SoundManager.instance.PlaySharfSound();
                gameProcess = 2;
                Debug.Log("process '1' -> '2'");
                Water.SetActive(false);   
            }
            FishHpBar.value = (float)MaxHp / (float)FishManager.instance.hp;
        }
    }
    
    private void FishingGame1()
    {
        Waiting_Text.text = "";
        Debug.Log("process '0' -> '1'");
        gameProcess = 1;
        FishSiluet.transform.position = new Vector2(Random.RandomRange(-1.2f, 1.2f), Random.RandomRange(-1.2f, 1.2f));
        Water.SetActive(true);   
    }
    
    IEnumerator FishSign()
    {
        MaxHp = FishManager.instance.hp;     
        yield return new WaitForSeconds(time);
        Debug.Log("낚시 게임시작");
        FishingGame1();
        yield return new WaitUntil(()=>gameProcess > 1);
        Sign_Image.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Sign_Image.SetActive(false);
        gameProcess = 3;
        Water2.SetActive(true);
        FishHpBar.gameObject.SetActive(true);
        FishHpBar.value = (float)MaxHp / (float)FishManager.instance.hp;
        yield return new WaitUntil(() => FishManager.instance.hp <= 0);
        gameProcess = 4;
        Water2.SetActive(false);
        FishHpBar.gameObject.SetActive(false); 
        Waiting_Text.text = "자 자 이리로 와... ▼";
        yield return new WaitUntil(() => Input.anyKeyDown);
        yield return new WaitUntil(() => Input.anyKeyDown);
        gameProcess = 5;
        FishManager.instance.isSucess = true;
        Waiting_Text.text = "";
        yield return new WaitUntil(() => FishManager.instance.isSucess == false);
        Waiting_Text.text = "낚시 성공!...▼\n";
        gameProcess = 6;
        yield return new WaitUntil(() => Input.anyKeyDown);
        Waiting_Text.text = FishManager.instance.money + "$를 벌었다!";
        yield return new WaitUntil(() => Input.anyKeyDown);
        gameProcess = 7;
        GameClear();
    }

    void GameClear()
    {
        Waiting_Text.text = "";
        isFishing = false;
        FishingButton.SetActive(true);
        gameProcess = -1;
    }

    public void ClickFishing()
    {
        gameProcess = 0;
        FishManager.instance.FishTier = (FishManager.Tier)Random.Range(0, 6);
        FishManager.instance.Summon(FishManager.instance.FishTier);
        FishingButton.SetActive(false);
        time = Random.RandomRange(5f, 7.50f);
        isFishing = true;
    }
}
