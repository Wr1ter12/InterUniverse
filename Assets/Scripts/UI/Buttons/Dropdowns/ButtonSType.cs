using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSType : MonoBehaviour
{
    public static string type;

    void Start()
    {
        type = "ER";
    }

    public void InputType(int value)
    {
        if(value == 0)
        {
            type = "ER";
        }
        if(value == 1)
        {
            type = "Km";
        }
    }
}
