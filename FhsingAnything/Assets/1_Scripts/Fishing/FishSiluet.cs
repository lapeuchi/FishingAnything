using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSiluet : MonoBehaviour
{
    ParticleSystem ps;
    Rigidbody2D rb;
    Vector2 vec;
    public bool isTrigger = false;
    public bool isGaming;
    [SerializeField] GameObject Fishing;
    
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        ps = gameObject.GetComponent<ParticleSystem>();
        Fishing = GameObject.Find("FishingManager");
        if (isGaming == false)
            InvokeRepeating("RandVec", 0f, 0.8f);
        else if (isGaming == true)
            RandVec();
    }

    void RandVec()
    {   
        rb.velocity = Vector2.zero;
        SoundManager.instance.PlayFishMoveSound();
        vec = new Vector2(Random.RandomRange(-1f, 1f), Random.RandomRange(-1f, 1f));
        if (isGaming == false)
            rb.AddForce(vec * 2f, ForceMode2D.Impulse); 
    }

    void Update()
    {
        float angle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);      
         if(isGaming == true)
            transform.Translate(vec * Time.deltaTime * 2f);

         if(isTrigger == true && Input.anyKeyDown)
         {   
            if (isGaming)
            {
                Debug.Log("gameprocess 2" + FishManager.instance.hp + "=>" + (FishManager.instance.hp - 100));
                FishManager.instance.hp -= 100;
                StartCoroutine(Particle());
            }
            else
                Destroy(gameObject);
        }
        if (FishManager.instance.hp <= 0)
        {
            SoundManager.instance.PlayCatchSound();
            Destroy(gameObject);
        }
            
    }

    IEnumerator Particle()
    {
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
        rb.constraints = 0;
        ps.Play();
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            isTrigger = true;          
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
    }
}
