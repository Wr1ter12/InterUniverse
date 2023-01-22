using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMType : MonoBehaviour
{
    public static string type;

    void Start()
    {
        type = "EM";
    }

    public void InputType(int value)
    {
        if(value == 0)
        {
            type = "EM";
        }
        if(value == 1)
        {
            type = "T";
        }
    }
}
