using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Transform firePosition;
    public GameObject bullet;

    void Update()
    {       
        if (Input.GetMouseButtonDown(0))
        {
            Object obj = Instantiate(bullet, firePosition.position, firePosition.rotation);
            Destroy(obj, 5.5f);
        } 
    }
}
