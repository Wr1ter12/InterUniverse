using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotQuit : MonoBehaviour
{
    [SerializeField] private Behaviour script;
    public GameObject Quit;

    public void onClick()
    {
        Time.timeScale = 1f;
        script.enabled = true;
        Quit.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
