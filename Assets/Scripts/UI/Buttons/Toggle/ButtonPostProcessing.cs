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
    public GameObject cam;

    void Start()
    {
        toggle = GetComponent<Toggle>();
        if(volume.activeSelf == false)
        {
            toggle.isOn = false;
            cam.GetComponent<PostProcessing>().save = 0;
            postprocess = false;
        }
        else
        {
            toggle.isOn = true;
            cam.GetComponent<PostProcessing>().save = 1;
            postprocess = true;
        }
        PlayerPrefs.SetInt("post", cam.GetComponent<PostProcessing>().save);
    }

    public void onToggle()
    {
        if(postprocess == false)
        {
            postprocess = true;
            cam.GetComponent<PostProcessing>().save = 1;
        }
        else
        {
            postprocess = false;
            cam.GetComponent<PostProcessing>().save = 0;
        }
        PlayerPrefs.SetInt("post", cam.GetComponent<PostProcessing>().save);
    }
}
