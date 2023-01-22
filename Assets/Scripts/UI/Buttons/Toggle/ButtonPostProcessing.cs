using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class ButtonPostProcessing : MonoBehaviour
{
    Toggle toggle;
    public static bool postprocess = false;
    public GameObject camera;

    void Start()
    {
        toggle = GetComponent<Toggle>();
        if(camera.GetComponent<PostProcessVolume>().enabled == false)
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
