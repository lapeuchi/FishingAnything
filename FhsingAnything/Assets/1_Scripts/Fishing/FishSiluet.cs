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
    float power;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        ps = gameObject.GetComponent<ParticleSystem>();
        Fishing = GameObject.Find("FishingManager");
        if (isGaming == false)
            StartCoroutine(RandVec());
        else if (isGaming == true)
            Fight();
    }

    IEnumerator RandVec()
    {
        if (isGaming == false)
        {
            
            rb.velocity = Vector2.zero;
            SoundManager.instance.PlayFishMoveSound();
            vec = new Vector2(Random.RandomRange(-1f, 1f), Random.RandomRange(-1f, 1f));
            rb.AddForce(vec * 2f, ForceMode2D.Impulse);
            ps.Play();
            yield return new WaitForSeconds(Random.Range(0.2f, 1.5f));
            StartCoroutine(RandVec());
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
        if (isGaming == true)
            transform.Translate(vec * Time.deltaTime * power);
        else
        {
            float angle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

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
