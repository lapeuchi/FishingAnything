using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSiluet : MonoBehaviour
{
    Vector2 vec;
    public bool isTrigger = false;
    public bool isGaming;
    [SerializeField] GameObject Fishing;

    private void Start()
    {
        Fishing = GameObject.Find("FishingManager");
        if (isGaming == false)
            InvokeRepeating("RandVec", 0f, 0.8f);
        else if (isGaming == true)
            RandVec();
    }

    void RandVec()
    {   
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        vec = new Vector2(Random.RandomRange(-1f, 1f), Random.RandomRange(-1f, 1f));
        if (isGaming == false)
            GetComponent<Rigidbody2D>().AddForce(vec * 2f, ForceMode2D.Impulse); 
    }

    void Update()
    {
        float angle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);      
         if(isGaming == true)
            transform.Translate(vec * Time.deltaTime * 2f);

         if(isTrigger == true && Input.anyKeyDown)
         {
            Destroy(gameObject);
         }
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
