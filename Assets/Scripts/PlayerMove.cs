using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float x, z, r, speed = 5;
    Transform tr;
    Animation anim;    

    void Start()
    {
        tr = GetComponent<Transform>();
        anim = GetComponent<Animation>();        
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        r = Input.GetAxis("Mouse X");

        Vector3 v3 = Vector3.forward * z + Vector3.right * x;

        tr.Translate(v3.normalized * Time.deltaTime *speed);
        tr.Rotate(0, r, 0);

        if(z > 0.1f)
        {
            anim.CrossFade("WalkF", 0.2f);
        } else if(z < -0.1f)
        {
            anim.CrossFade("WalkB", 0.2f);
        } else if (x >0.1f)
        {
            anim.CrossFade("WalkR", 0.2f);
        } else if (x <-0.1f)
        {
            anim.CrossFade("WalkL", 0.2f);
        } else
        {
            anim.CrossFade("Idle", 0.2f);
        }
        
    }
}
