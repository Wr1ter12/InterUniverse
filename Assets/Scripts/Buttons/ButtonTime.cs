using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTime : MonoBehaviour
{
    public void InputTime(int value)
    {
        if(value == 0)
        {
            Time.timeScale = 1.0f;
        }
        if(value == 1)
        {
            Time.timeScale = 2.0f;
        }
        if(value == 2)
        {
            Time.timeScale = 3.0f;
        }
        if(value == 3)
        {
            Time.timeScale = 4.0f;
        }
        if(value == 4)
        {
            Time.timeScale = 5.0f;
        }
        if(value == 5)
        {
            Time.timeScale = 25.0f;
        }
        if(value == 6)
        {
            Time.timeScale = 0.5f;
        }
        if(value == 7)
        {
            Time.timeScale = 0.33f;
        }
        if(value == 8)
        {
            Time.timeScale = 0.25f;
        }
        if(value == 9)
        {
            Time.timeScale = 0.2f;
        }
    }
}
