using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PBLPBR : MonoBehaviour
{
    [SerializeField] Image PBL;
    [SerializeField] Image PBR;
    [SerializeField] int turnSpeed;
    void Update()
    {
        PBL.transform.Rotate(Vector2.left, turnSpeed * Time.deltaTime);
        PBL.transform.Rotate(Vector2.down, turnSpeed * Time.deltaTime);
        PBR.transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
    }
}
