using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCoordinates : MonoBehaviour
{
    Toggle toggle;
    public static bool coords = false;
    public GameObject cam;

    void Start()
    {
        toggle = GetComponent<Toggle>();
        if(cam.GetComponent<Coords>().save == 0)
        {
            toggle.isOn = false;
            cam.GetComponent<Coords>().save = 0;
            coords = false;
        }
        else
        {
            toggle.isOn = true;
            cam.GetComponent<Coords>().save = 1;
            coords = true;
        }
        PlayerPrefs.SetInt("coords", cam.GetComponent<Names>().save);
    }

    public void onToggle()
    {
        if(coords == false)
        {
            coords = true;
            cam.GetComponent<Coords>().save = 1;
        }
        else
        {
            coords = false;
            cam.GetComponent<Coords>().save = 0;
        }
        PlayerPrefs.SetInt("coords", cam.GetComponent<Coords>().save);
    }
}
