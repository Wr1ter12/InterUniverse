using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class ButtonPostProcessing : MonoBehaviour
{
    Toggle toggle;
    public GameObject volume;
    public static bool postprocess = false;

    void Start()
    {
        toggle = GetComponent<Toggle>();
        if(volume.activeSelf == false)
        {
            toggle.isOn = false;
            postprocess = false;
        }
        else
        {
            toggle.isOn = true;
            postprocess = true;
        }
    }

    public void onToggle()
    {
         if(postprocess == false)
         {
            postprocess = true;
         }
         else
         {
            postprocess = false;
         }
    }
}
