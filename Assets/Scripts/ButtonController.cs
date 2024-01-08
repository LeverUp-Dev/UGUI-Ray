using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public void PlayClick()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void PauseClick()
    {
        Time.timeScale = 0;
    }
}
