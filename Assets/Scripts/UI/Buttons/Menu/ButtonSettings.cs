using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSettings : MonoBehaviour
{
    public GameObject Settings;
    public GameObject Menu;

    public void onClick()
    {
        Settings.SetActive(true);
        Menu.SetActive(false);
    }
}
