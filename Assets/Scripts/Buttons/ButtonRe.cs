using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRe : MonoBehaviour
{
    public void onClick()
    {

        if (Time.timeScale != 100.0f)
        {
            Time.timeScale = 100.0f;
        }
        else {
            Time.timeScale = 1.0f;
        }
    }
}