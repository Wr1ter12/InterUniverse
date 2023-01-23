using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCreate : MonoBehaviour
{
    public GameObject planet;
    [SerializeField] private Behaviour script;
    public GameObject input;

    public GameObject tutor;
    public GameObject change;
    public GameObject quit;

    public void onClick()
    {
        if(change.activeSelf == false && tutor.activeSelf == false && quit.activeSelf == false)
        {
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.Confined;
            script.enabled = false;
            input.SetActive(true);
        }
    }
}
