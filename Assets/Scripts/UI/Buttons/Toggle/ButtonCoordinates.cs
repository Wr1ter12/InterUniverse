using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCoordinates : MonoBehaviour
{
    Toggle toggle;
    public static bool coords = false;

    void Start()
    {
        toggle = GetComponent<Toggle>();
    }

    public void onToggle()
    {
         if(coords == false)
         {
            coords = true;
         }
         else
         {
            coords = false;
         }
    }
}
