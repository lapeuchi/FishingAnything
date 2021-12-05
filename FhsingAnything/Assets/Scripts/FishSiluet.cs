using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSiluet : MonoBehaviour
{
    Vector2 vec;
    public bool isTrigger=false;

    private void Start()
    {
        InvokeRepeating("RandVec", 0f, 0.8f);
    }

    void RandVec()
    {
        vec = new Vector2(Random.RandomRange(-1f, 1f), Random.RandomRange(-1f, 1f));
        GetComponent<Rigidbody2D>().AddForce(vec, ForceMode2D.Impulse);
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
