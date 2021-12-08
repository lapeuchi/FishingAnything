using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSiluet : MonoBehaviour
{
    Vector2 vec;
    public bool isTrigger = false;
    public bool isGaming;

    private void Start()
    {
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
            GetComponent<Rigidbody2D>().AddForce(vec, ForceMode2D.Impulse); 
    }

    void Update()
    {
        float angle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);      
         if(isGaming == true)
            transform.Translate(vec * Time.deltaTime * 2f);
    }

    public void OnTriggerStay2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            isTrigger = true;
            if(Input.anyKeyDown)
                Destroy(gameObject);
        }
        else
            isTrigger = false;

        if(other.gameObject.CompareTag("Respawn"))
        {
            Destroy(gameObject, 6f);
        }
    }
}
