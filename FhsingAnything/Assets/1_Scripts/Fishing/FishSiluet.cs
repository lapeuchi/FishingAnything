using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            vec = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
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
        }
        
        


        if (Fishing.instance.gameProcess == 1)
            StartCoroutine(RandVec());
        if (isGaming == true)
        {
            transform.Translate(vec * Time.deltaTime * power);
            
        }           
        else
        {
            float angle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
     
        if (FishManager.instance.hp <= 0)
        {            
            Destroy(gameObject);
        }
    }

    IEnumerator Particle()
    {
        Debug.Log("gameprocess 2" + FishManager.instance.hp + "=>" + (FishManager.instance.hp - (GameManager.instance.Strength * 0.5f)));
        FishManager.instance.hp -= + (GameManager.instance.Strength * 0.5f);
        Fishing.instance.FishHpBar.value = FishManager.instance.hp / Fishing.instance.FishMaxHp;
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
        rb.constraints = 0;
        ps.Play();
        yield return new WaitForSeconds(0.1f);
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
        }

        if (other.gameObject.CompareTag("Up"))
        {
            isTrigger = false;
            isUpTrigger = false;
            GameManager.instance.Stamina -= 1f;
            Fishing.instance.PlayerHpBar.value = GameManager.instance.Stamina / Fishing.instance.PlayerMaxHp;
        }
        if (other.gameObject.CompareTag("Down"))
        {
            isTrigger = false;
            isDownTrigger = false;
            GameManager.instance.Stamina -= 1f;
            Fishing.instance.PlayerHpBar.value = GameManager.instance.Stamina / Fishing.instance.PlayerMaxHp;
        }
        if (other.gameObject.CompareTag("Left"))
        {
            isTrigger = false;
            isLeftTrigger = false;
            GameManager.instance.Stamina -= 1f;
            Fishing.instance.PlayerHpBar.value = GameManager.instance.Stamina / Fishing.instance.PlayerMaxHp;
        }
        if (other.gameObject.CompareTag("Right"))
        {
            isRightTrigger = false;
            GameManager.instance.Stamina -= 1f;
            Fishing.instance.PlayerHpBar.value = GameManager.instance.Stamina / Fishing.instance.PlayerMaxHp;
        }
    }
}
