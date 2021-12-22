using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishSiluet : MonoBehaviour
{
    ParticleSystem ps;
    Rigidbody2D rb;
    Vector2 vec;
    public bool isTrigger = false;
    public bool isUpTrigger = false;
    public bool isDownTrigger = false;
    public bool isLeftTrigger = false;
    public bool isRightTrigger = false;
    public bool isGaming;
    [SerializeField] GameObject FishingManager;
    float power;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        ps = gameObject.GetComponent<ParticleSystem>();
        FishingManager = GameObject.Find("FishingManager");
        //if (isGaming == false)
         //   StartCoroutine(RandVec());
         if (isGaming == true)
            Fight();
    }

    IEnumerator RandVec()
    {
        if (isGaming == false)
        {          
            Fishing.instance.gameProcess = -3;
            rb.velocity = Vector2.zero;
            SoundManager.instance.PlayFishMoveSound();
            float r = Random.Range(0f, 100f);
            if(r <= GameManager.instance.ComePower)
            {
                Fishing.instance.SignText.text = "슈우웅!";
                vec = new Vector2(0, 0) - (Vector2)transform.position;
            }
            else
            {
                Fishing.instance.SignText.text = "//...";
                vec = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            }
            
            rb.AddForce(vec * 2f, ForceMode2D.Impulse);
            ps.Play();
            yield return new WaitForSeconds(Random.Range(0.2f, 1.5f));
            StartCoroutine(RandVec());
            if (Fishing.instance.gameProcess == 1)
                StopCoroutine(RandVec());
        }
    }

    void Fight()
    {
        power = Random.Range(3f, 5f);
        int i = Random.Range(0, 4);
        if (i == 0)
            vec = Vector2.up;
        if (i == 1)
            vec = Vector2.down;
        if (i == 2)
            vec = Vector2.left;
        if (i == 3)
            vec = Vector2.right;
       
    }

    void Update()
    {
        if (isTrigger == true)
        {
            if (isGaming)
            {
                if (isUpTrigger && Input.GetKeyDown(KeyCode.UpArrow) || isDownTrigger && Input.GetKeyDown(KeyCode.DownArrow) || isLeftTrigger && Input.GetKeyDown(KeyCode.LeftArrow) || isRightTrigger && Input.GetKeyDown(KeyCode.RightArrow))
                    StartCoroutine(Particle());
            }
            else if (Input.anyKeyDown && isGaming == false) 
            {
                Fishing.instance.gameProcess = 1;
                Destroy(gameObject);
            }
            else if (isGaming == false)
            {
                Fishing.instance.SignText.text = "보인다!! 빈틈의 실!!!";
            }
        }           

        if (Fishing.instance.gameProcess == 1)
            StartCoroutine(RandVec());
        if (isGaming == true)
        {
            transform.Translate(vec * Time.deltaTime * power);
            // float angle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;
            //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        
        else
        {
            float angle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
          //Quaternion rot = Quaternion.LookRotation(vec.normalized);
          //transform.rotation = rot;
        }
     
        //이겼을 때
        if (FishManager.instance.hp <= 0)
        {
            SoundManager.instance.PlayCatchSound();
            Destroy(gameObject);
        }
        //졌을 때
        if(GameManager.instance.Stamina <= 0)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Particle()
    {
        Debug.Log(FishManager.instance.hp + "=>" + (FishManager.instance.hp - (10 + (GameManager.instance.Strength * 0.1f))));
        FishManager.instance.hp -= 10 + ((GameManager.instance.Strength + GameManager.instance.Strength_Equip)* 0.1f);
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
        rb.constraints = 0;
        ps.Play();
        yield return null;
        Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            isTrigger = true;          
        }

        if(other.gameObject.CompareTag("Up"))
        {
            isTrigger = true;
            isUpTrigger = true;
        }
        if (other.gameObject.CompareTag("Down"))
        {
            isTrigger = true;
            isDownTrigger = true;
        }
        if (other.gameObject.CompareTag("Left"))
        {
            isTrigger = true;
            isLeftTrigger = true;
        }
        if (other.gameObject.CompareTag("Right"))
        {
            isTrigger = true;
            isRightTrigger = true;
        }

        if (other.gameObject.CompareTag("Untagged"))
            isTrigger = false;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Finish"))
        {
            isTrigger = false; 
            if (isGaming == false)
            {
                Fishing.instance.SignText.text = "";
            }
        }

        if (other.gameObject.CompareTag("Up"))
        {
            GameManager.instance.Stamina -= 2;
            Fishing.instance.PlayerHpBar.value = GameManager.instance.Stamina / GameManager.instance.Max_Stamina;
            isTrigger = false;
            isUpTrigger = false;
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Down"))
        {
            GameManager.instance.Stamina -= 2;
            Fishing.instance.PlayerHpBar.value = GameManager.instance.Stamina / GameManager.instance.Max_Stamina;
            isTrigger = false;
            isDownTrigger = false;
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Left"))
        {
            GameManager.instance.Stamina -= 2;
            Fishing.instance.PlayerHpBar.value = GameManager.instance.Stamina / GameManager.instance.Max_Stamina;
            isTrigger = false;
            isLeftTrigger = false;
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Right"))
        {
            GameManager.instance.Stamina -= 2;
            Fishing.instance.PlayerHpBar.value = GameManager.instance.Stamina / GameManager.instance.Max_Stamina;
            isTrigger = false;
            isRightTrigger = false;
            Destroy(gameObject);
        }
    }
}
