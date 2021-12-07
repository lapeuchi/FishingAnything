using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSiluet : MonoBehaviour
{
    Vector2 vec;
    public bool isTrigger=false;
    public byte gamePrograss = 0;
    
    private void Awake()
    {
        
        gamePrograss = 1;
    }

    private void Start()
    {
        if (gamePrograss == 1)
            InvokeRepeating("RandVec", 0f, 0.8f);

    }

    void RandVec()
    {
        if(gamePrograss == 1)
        {
            vec = Vector2.zero;
            vec = new Vector2(Random.RandomRange(-1f, 1f), Random.RandomRange(-1f, 1f));
            GetComponent<Rigidbody2D>().AddForce(vec, ForceMode2D.Impulse);
        }
        
    }

    void Update()
    {
        if(gamePrograss == 1)
        {
            float angle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    public void OnTriggerStay2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            isTrigger = true;
        }
        else
            isTrigger = false;
    }
}
