using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonNames : MonoBehaviour
{
    Toggle toggle;
    public static bool names = false;
    public GameObject cam;

    void Start()
    {
        toggle = GetComponent<Toggle>();
        if(cam.GetComponent<Names>().save == 0)
        {
            toggle.isOn = false;
            cam.GetComponent<Names>().save = 0;
            names = false;
        }
        else
        {
            toggle.isOn = true;
            cam.GetComponent<Names>().save = 1;
            names = true;
        }
        PlayerPrefs.SetInt("names", cam.GetComponent<Names>().save);
    }

    public void onToggle()
    {
        if(names == false)
        {
            names = true;
            cam.GetComponent<Names>().save = 1;
        }
        else
        {
            names = false;
            cam.GetComponent<Names>().save = 0;
        }
        PlayerPrefs.SetInt("names", cam.GetComponent<Names>().save);
    }
}
