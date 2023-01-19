using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPosType : MonoBehaviour
{
    public static string type;

    void Start()
    {
        type = "AU";
    }

    public void InputType(int value)
    {
        if(value == 0)
        {
            type = "AU";
        }
        if(value == 1)
        {
            type = "Km";
        }
    }
}
