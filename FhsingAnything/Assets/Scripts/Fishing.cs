using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fishing : MonoBehaviour
{
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
    [SerializeField] byte gameProcess = 0;

    [SerializeField] private GameObject Sign_Image;
    [SerializeField] private Text Waiting_Text;
    [SerializeField] private GameObject Water;
    [SerializeField] public GameObject FishSiluet;

    [SerializeField] private Slider FishHp;
    [SerializeField] private Slider AttackBar;

    Rigidbody2D rigid;


    void Start()
    {
        
        if(GameManager.instance.fishing_Place_State == GameManager.FishingState.Sea)
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
        if(isFishing == true)
        {
            StartCoroutine(FishSign());

            isFishing = false;
        }

        if (FishSiluet.GetComponent<FishSiluet>().isTrigger && Input.anyKeyDown)
        {
            gameProcess = 1;
            Debug.Log("process '0' clear. -> '1'");
            FishSiluet.GetComponent<FishSiluet>().isTrigger = false;
            Water.SetActive(false);
          
        }

        if(FishSiluet.GetComponent<FishSiluet>().gamePrograss == 2)
        {
            FishSiluet.SetActive(true);
            FishSiluet.transform.position = new Vector2(0, 3);
        }
    }
    
    private void FishingGame1()
    {
        FishSiluet.transform.position = new Vector2(Random.RandomRange(-1.2f, 1.2f), Random.RandomRange(-1.2f, 1.2f));
        Water.SetActive(true);   
    }
    
    IEnumerator FishSign()
    {
        Waiting_Text.gameObject.SetActive(true);
        yield return new WaitForSeconds(time);
        Waiting_Text.gameObject.SetActive(false);
        Debug.Log("낚시 게임시작");
        FishingGame1();
        yield return new WaitUntil(()=>gameProcess > 0);
        Sign_Image.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Sign_Image.SetActive(false);
        yield return new WaitForSeconds(0.4f);
        Water.SetActive(true);
        FishSiluet.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        FishSiluet.GetComponent<FishSiluet>().gamePrograss = 2;
        gameProcess = 2;
        InvokeRepeating("SummonSiluet", 1, 1);
    }

    public void ClickFishing()
    {
        time = Random.RandomRange(5f, 11.50f);
        isFishing = true;
        FishingButton.SetActive(false);
    }

    private void SummonSiluet()
    {
        Vector3 pos = Vector3.zero;
        int rand = Random.Range(0, 3);
        if (rand == 0)
            pos = new Vector3(-2, 0, 0);
        if (rand == 1)
            pos = new Vector3(2, 0, 0);
        if (rand == 2)
            pos = new Vector3(0, -1.5f, 0);
        if (rand == 3)
            pos = new Vector3(0, 1.5f, 0);

      //  float angle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
      //  transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

      //  Instantiate(FishSiluet, pos, Quaternion.AngleAxis(angle, Vector3.forward));
    }
}
