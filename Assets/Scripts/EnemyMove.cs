﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    Animator anim;
    NavMeshAgent nvAgent;
    public Transform Player;
    public Image hpBar;

    public Text txt;
    int score;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        nvAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float dist = Vector3.Distance(Player.position, transform.position);
                
        
        if(dist <3)
        {
            anim.SetBool("IsRun", false);
        } else if(dist < 10 )
        {
            nvAgent.destination = Player.position;
            anim.SetBool("IsRun", true);
        } else
        {
            nvAgent.velocity = Vector3.zero;
            anim.SetBool("IsRun", false);
        }
              

        if (Input.GetMouseButton(1))
        {
            anim.SetBool("IsDance", true);
        }
        else
        {
            anim.SetBool("IsDance", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            hpBar.fillAmount -= 0.25f;
            score++;
            txt.text = "Score : " + score;

            if(score == 4)
            {
                SceneManager.LoadScene("SecondScene");
            }
        }
    }
}
