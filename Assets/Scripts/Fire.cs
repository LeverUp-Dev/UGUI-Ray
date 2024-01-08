using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Transform firePosition;
    public GameObject bullet;

    RaycastHit hit;

    void Update()
    {
        Debug.DrawRay(firePosition.position, firePosition.forward * 10, Color.blue);

        if (Input.GetMouseButtonDown(0))
        {
            Object obj = Instantiate(bullet, firePosition.position, firePosition.rotation);
            Destroy(obj, 5.5f);

            if(Physics.Raycast(firePosition.position, firePosition.forward, out hit, 100))
            {
                if(hit.collider.tag == "Enemy")
                {
                    Debug.Log("Enemy Die");
                }
            }
        } 
    }
}
