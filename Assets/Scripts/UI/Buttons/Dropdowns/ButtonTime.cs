using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonTime : MonoBehaviour
{
    GameObject obj;
    public Sprite[] sprites = new Sprite[10];

    public void Start()
    {
        obj = GameObject.Find("ButtonTime");
    }

    public void InputTime(int value)
    {
        if(value == 0)
        {
            Time.timeScale = 1.0f;
        }
        if(value == 1)
        {
            Time.timeScale = 2.0f;
        }
        if(value == 2)
        {
            Time.timeScale = 3.0f;
        }
        if(value == 3)
        {
            Time.timeScale = 4.0f;
        }
        if(value == 4)
        {
            Time.timeScale = 5.0f;
        }
        if(value == 5)
        {
            Time.timeScale = 25.0f;
        }
        if(value == 6)
        {
            Time.timeScale = 0.5f;
        }
        if(value == 7)
        {
            Time.timeScale = 0.33f;
        }
        if(value == 8)
        {
            Time.timeScale = 0.25f;
        }
        if(value == 9)
        {
            Time.timeScale = 0.2f;
        }
    }

    public void Update()
    {
        if(Time.timeScale == 1.0f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 0;
            obj.GetComponent<Image>().sprite = sprites[0];
        }
        if(Time.timeScale == 2.0f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 1;
            obj.GetComponent<Image>().sprite = sprites[1];
        }
        if(Time.timeScale == 3.0f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 2;
            obj.GetComponent<Image>().sprite = sprites[2];
        }
        if(Time.timeScale == 4.0f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 3;
            obj.GetComponent<Image>().sprite = sprites[3];
        }
        if(Time.timeScale == 5.0f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 4;
            obj.GetComponent<Image>().sprite = sprites[4];
        }
        if(Time.timeScale == 25.0f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 5;
            obj.GetComponent<Image>().sprite = sprites[5];
        }
        if(Time.timeScale == 0.5f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 6;
            obj.GetComponent<Image>().sprite = sprites[6];
        }
        if(Time.timeScale == 0.33f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 7;
            obj.GetComponent<Image>().sprite = sprites[7];
        }
        if(Time.timeScale == 0.25f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 8;
            obj.GetComponent<Image>().sprite = sprites[8];
        }
        if(Time.timeScale == 0.2f)
        {
            obj.GetComponent<TMP_Dropdown>().value = 9;
            obj.GetComponent<Image>().sprite = sprites[9];
        }
    }
}
