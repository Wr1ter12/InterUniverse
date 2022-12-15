using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTutorial : MonoBehaviour
{
    [SerializeField] private Behaviour script;
    public GameObject tutor;
    public bool tutorial;

    void Start() {
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
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            script.enabled = true;
            tutor.SetActive(false);
        }
    }
}
