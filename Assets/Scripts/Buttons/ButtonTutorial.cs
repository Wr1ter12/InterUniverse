using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonTutorial : MonoBehaviour
{
    GameObject obj;
    [SerializeField] private Behaviour script;
    public GameObject tutor;
    public bool tutorial;

    void Start() {
        obj = GameObject.Find("ButtonTime");
        tutorial = false;
    }

    public void onClick()
    {
        if(tutorial == false)
        {
            tutorial = true;
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.Confined;
            script.enabled = false;
            tutor.SetActive(true);
        }
        else
        {
            tutorial = false;
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
            Cursor.lockState = CursorLockMode.Locked;
            script.enabled = true;
            tutor.SetActive(false);
        }
    }
}
