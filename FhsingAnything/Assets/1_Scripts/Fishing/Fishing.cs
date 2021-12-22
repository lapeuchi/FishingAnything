using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public GameObject FishingButton;

    private bool isFishing = false;
    private float time = 0.0f;
    public int gameProcess = -1;

    public GameObject Sign_Image;
    public Text Waiting_Text;
    public Image Background_Waiting_Text;
    public GameObject Water;
    public GameObject Water2; // It used when FishSiluet's 'isGaming' is true
    public GameObject FishSiluet;
    public Slider FishHpBar;
    public Slider PlayerHpBar;
    
    public float FishMaxHp;
    public float PlayerMaxHp;
    Animator anim;
    public GameObject Charactor;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        Background_Waiting_Text.color = new Color(1, 1, 1, 0);
        gameProcess = -1;
        Waiting_Text.text = "";
        SetMap();
        Charactor = GameObject.Find("sword_man");
        anim = Charactor.GetComponent<Animator>();
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
        FishHpBar.value = FishManager.instance.hp / FishMaxHp;
        if (isFishing == true)
        {
            StartCoroutine(FishSign());

            isFishing = false;
        }

        if (FishSiluet.GetComponent<FishSiluet>().isTrigger && Input.anyKeyDown)
        {
            if (gameProcess == -3)
                gameProcess = 1;
            Debug.Log("isTrigger = true");
            if (gameProcess == 1)
            {                
                SoundManager.instance.PlaySharfSound();
                gameProcess = 2;
                Debug.Log("process '1' -> '2'");
                Water.SetActive(false);   
            }           
        }

        if(GameManager.instance.Stamina <= 0)
        {
            GameClear();
            Waiting_Text.text = "앗! 물고기한테 당했다. 마을로 돌아가자 ...▼";
            if (Input.anyKeyDown)
                SceneManager.LoadScene("FishMarketScene");
            GameManager.instance.Save();
        }
    }
    
    private void FishingGame1()
    {
        Background_Waiting_Text.color = new Color(1, 1, 1, 0);
        Waiting_Text.text = "";
        Debug.Log("process '0' -> '1'");
        gameProcess = 1;
        FishSiluet.transform.position = new Vector2(Random.Range(-1.2f, 1.2f), Random.Range(-1.2f, 1.2f));
        Water.SetActive(true);   
    }
    
    IEnumerator FishSign()
    {
        yield return new WaitForSeconds(time);
        Debug.Log("낚시 게임시작");
        FishingGame1();
        yield return new WaitUntil(()=>gameProcess > 1);
        Sign_Image.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Sign_Image.SetActive(false);
        gameProcess = 3;
        FishMaxHp = FishManager.instance.hp;
        FishHpBar.value = FishManager.instance.hp / FishMaxHp;
        PlayerMaxHp = GameManager.instance.Stamina;
        PlayerHpBar.value = GameManager.instance.Stamina / PlayerMaxHp;
        Water2.SetActive(true);
        FishHpBar.gameObject.SetActive(true);
        PlayerHpBar.gameObject.SetActive(true);
        yield return new WaitUntil(() => FishManager.instance.hp <= 0);
        gameProcess = 4;
        yield return new WaitForSeconds(0.5f);
        Water2.SetActive(false);
        FishHpBar.gameObject.SetActive(false);
        PlayerHpBar.gameObject.SetActive(false);
        Background_Waiting_Text.color = new Color(1, 1, 1, 0.4f);
        Waiting_Text.text = "자 자 이리로 와... ▼";
        yield return new WaitUntil(() => Input.anyKeyDown);
        yield return new WaitUntil(() => Input.anyKeyDown);
        gameProcess = 5;
        FishManager.instance.isSucess = true;
        Background_Waiting_Text.color = new Color(1, 1, 1, 0);
        Waiting_Text.text = "";
        yield return new WaitUntil(() => FishManager.instance.isSucess == false);
        Background_Waiting_Text.color = new Color(1, 1, 1, 0.4f);
        SoundManager.instance.PlayCatchSound();
        Waiting_Text.text = "낚시 성공!...▼\n";
        gameProcess = 6;
        yield return new WaitUntil(() => Input.anyKeyDown);
        yield return new WaitUntil(() => Input.anyKeyDown);
        Waiting_Text.text = FishManager.instance.money + "$를 벌었다!";
        yield return new WaitUntil(() => Input.anyKeyDown);
        gameProcess = 8;
        yield return new WaitForSeconds(0.3f);
        GameClear();
    }

    void GameClear()
    {
        Water.SetActive(false);
        Water2.SetActive(false);
        FishHpBar.gameObject.SetActive(false);
        PlayerHpBar.gameObject.SetActive(false);
        Sign_Image.SetActive(false);

        gameProcess = -1;
        Background_Waiting_Text.color = new Color(1, 1, 1, 0);
        Waiting_Text.text = "";
        isFishing = false;
        FishingButton.SetActive(true);
        GameManager.instance.Save();
    }

    public void ClickFishing()
    {
        gameProcess = 0;
        FishManager.instance.FishTier = FishManager.instance.RandTier();
        FishManager.instance.Summon(FishManager.instance.FishTier);
        FishingButton.SetActive(false);
        time = Random.Range(5f, 7.50f);
        isFishing = true;
        anim.SetTrigger("Fishing");
    }
}
