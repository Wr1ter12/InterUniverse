using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonType : MonoBehaviour
{
    public static string type;

    void Start()
    {
        type = "planet";
    }

    public void InputType(int value)
    {
        if(value == 0)
        {
            type = "planet";
        }
        if(value == 1)
        {
            type = "star";
        }
        if(value == 2)
        {
            type = "blackhole";
        }
        if(value == 3)
        {
            type = "whitehole";
        }
    }
}
