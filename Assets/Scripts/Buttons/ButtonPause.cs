using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonPause : MonoBehaviour
{
    GameObject obj;
    public GameObject button;
    public Sprite[] sprites = new Sprite[2];

    public void Start()
    {
        obj = GameObject.Find("ButtonTime");
    }

    public void onClick()
    {
        if (Time.timeScale != 0.0f)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            if(obj.GetComponent<TMP_Dropdown>().value == 0)
            {
                Time.timeScale = 1.0f;
            }
            if(obj.GetComponent<TMP_Dropdown>().value == 1)
            {
                Time.timeScale = 2.0f;
            }
            if(obj.GetComponent<TMP_Dropdown>().value == 2)
            {
                Time.timeScale = 3.0f;
            }
            if(obj.GetComponent<TMP_Dropdown>().value == 3)
            {
                Time.timeScale = 4.0f;
            }
            if(obj.GetComponent<TMP_Dropdown>().value == 4)
            {
                Time.timeScale = 5.0f;
            }
            if(obj.GetComponent<TMP_Dropdown>().value == 5)
            {
                Time.timeScale = 25.0f;
            }
            if(obj.GetComponent<TMP_Dropdown>().value == 6)
            {
                Time.timeScale = 0.5f;
            }
            if(obj.GetComponent<TMP_Dropdown>().value == 7)
            {
                Time.timeScale = 0.33f;
            }
            if(obj.GetComponent<TMP_Dropdown>().value == 8)
            {
                Time.timeScale = 0.25f;
            }
            if(obj.GetComponent<TMP_Dropdown>().value == 9)
            {
                Time.timeScale = 0.2f;
            }
        }
    }

    public void Update() {
        if (Time.timeScale == 0.0f)
        {
            button.GetComponent<Image>().sprite = sprites[1];
        }
        else
        {
            button.GetComponent<Image>().sprite = sprites[0];
        }
    }
}
