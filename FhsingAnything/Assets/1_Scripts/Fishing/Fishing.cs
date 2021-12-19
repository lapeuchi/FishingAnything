using System.Collections;
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
    public byte gameProcess = 0;

    [SerializeField] private GameObject Sign_Image;
    [SerializeField] private Text Waiting_Text;
    [SerializeField] private GameObject Water;
    [SerializeField] private GameObject Water2; // It used when FishSiluet's 'isGaming' is true
    [SerializeField] public GameObject FishSiluet;

    [SerializeField] private Slider FishHpBar;
    int MaxHp;
    private float fSliderBarTime;
    Rigidbody2D rigid;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
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
            if (gameProcess == 0)
            {
                SoundManager.instance.PlaySharfSound();
                gameProcess = 1;
                Debug.Log("process '0' clear. -> '1'");
                Water.SetActive(false);   
            }
            
        }
    }
    
    private void FishingGame1()
    {
        FishSiluet.transform.position = new Vector2(Random.RandomRange(-1.2f, 1.2f), Random.RandomRange(-1.2f, 1.2f));
        Water.SetActive(true);   
    }
    
    IEnumerator FishSign()
    {
        MaxHp = FishManager.instance.hp;     
        Waiting_Text.gameObject.SetActive(true);
        yield return new WaitForSeconds(time);
        Waiting_Text.gameObject.SetActive(false);
        Debug.Log("낚시 게임시작");
        FishingGame1();
        yield return new WaitUntil(()=>gameProcess > 0);
        Water.SetActive(false);
        Sign_Image.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Sign_Image.SetActive(false);
        gameProcess = 2;
        Water2.SetActive(true);
        yield return new WaitUntil(() => FishManager.instance.hp <= 0);
        FishManager.instance.isSucess = true;
        Water2.SetActive(false);
        Waiting_Text.gameObject.SetActive(true);
        Waiting_Text.text = "자 자 이리로 와... ▼";
        yield return new WaitUntil(() => Input.anyKeyDown);
        Waiting_Text.text = "낚시 성공!...▼\n";
        yield return new WaitUntil(() => Input.anyKeyDown);
        gameProcess = 3;
        
    }

    public void ClickFishing()
    {
        FishManager.instance.FishTier = (FishManager.Tier)Random.Range(0, 6);
        FishManager.instance.Summon(FishManager.instance.FishTier);
        FishingButton.SetActive(false);
        time = Random.RandomRange(5f, 7.50f);
        isFishing = true;
    }
}
