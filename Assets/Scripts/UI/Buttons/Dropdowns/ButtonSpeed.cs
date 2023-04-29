using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonSpeed : MonoBehaviour
{
    GameObject obj;
    public Sprite[] sprites = new Sprite[8];

    public void Start()
    {
        obj = GameObject.Find("ButtonSpeed");
    }

    public void InputSpeed(int value)
    {
        if(value == 0)
        {
            Camera.main.GetComponent<FlyCamera>().mainSpeed = 1000.0f;
            Camera.main.GetComponent<FlyCamera>().shiftAdd = 2500.0f;
        }
        if(value == 1)
        {
            Camera.main.GetComponent<FlyCamera>().mainSpeed = 2000.0f;
            Camera.main.GetComponent<FlyCamera>().shiftAdd = 5000.0f;
        }
        if(value == 2)
        {
            Camera.main.GetComponent<FlyCamera>().mainSpeed = 3000.0f;
            Camera.main.GetComponent<FlyCamera>().shiftAdd = 7500.0f;
        }
        if(value == 3)
        {
            Camera.main.GetComponent<FlyCamera>().mainSpeed = 4000.0f;
            Camera.main.GetComponent<FlyCamera>().shiftAdd = 10000.0f;
        }
        if(value == 4)
        {
            Camera.main.GetComponent<FlyCamera>().mainSpeed = 5000.0f;
            Camera.main.GetComponent<FlyCamera>().shiftAdd = 12500.0f;
        }
        if(value == 5)
        {
            Camera.main.GetComponent<FlyCamera>().mainSpeed = 500.0f;
            Camera.main.GetComponent<FlyCamera>().shiftAdd = 1250.0f;
        }
        if(value == 6)
        {
            Camera.main.GetComponent<FlyCamera>().mainSpeed = 250.0f;
            Camera.main.GetComponent<FlyCamera>().shiftAdd = 625.0f;
        }
        if(value == 7)
        {
            Camera.main.GetComponent<FlyCamera>().mainSpeed = 100.0f;
            Camera.main.GetComponent<FlyCamera>().shiftAdd = 250.0f;
        }
    }

    public void Update()
    {
        if(Camera.main.GetComponent<FlyCamera>().mainSpeed == 1000.0f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 0;
            obj.GetComponent<Image>().sprite = sprites[0];
        }
        if(Camera.main.GetComponent<FlyCamera>().mainSpeed == 2000.0f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 1;
            obj.GetComponent<Image>().sprite = sprites[1];
        }
        if(Camera.main.GetComponent<FlyCamera>().mainSpeed == 3000.0f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 2;
            obj.GetComponent<Image>().sprite = sprites[4];
        }
        if(Camera.main.GetComponent<FlyCamera>().mainSpeed == 4000.0f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 3;
            obj.GetComponent<Image>().sprite = sprites[5];
        }
        if(Camera.main.GetComponent<FlyCamera>().mainSpeed == 5000.0f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 4;
            obj.GetComponent<Image>().sprite = sprites[6];
        }
        if(Camera.main.GetComponent<FlyCamera>().mainSpeed == 500.0f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 5;
            obj.GetComponent<Image>().sprite = sprites[2];
        }
        if(Camera.main.GetComponent<FlyCamera>().mainSpeed == 250.0f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 6;
            obj.GetComponent<Image>().sprite = sprites[3];
        }
        if(Camera.main.GetComponent<FlyCamera>().mainSpeed == 100.0f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 7;
            obj.GetComponent<Image>().sprite = sprites[7];
        }
    }
}
