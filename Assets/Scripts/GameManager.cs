using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject uiMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            uiMenu.SetActive(true);
        }
    }
}
