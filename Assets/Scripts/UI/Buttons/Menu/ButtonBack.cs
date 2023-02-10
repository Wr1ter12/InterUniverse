using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBack : MonoBehaviour
{
    public GameObject Settings;
    public GameObject Menu;

    public void onClick()
    {
        Menu.SetActive(true);
        Settings.SetActive(false);
    }
}
