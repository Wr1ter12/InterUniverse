using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCancel : MonoBehaviour
{
    public GameObject input;
    [SerializeField] private Behaviour script;
    GameObject planet;

    public void onClick()
    {
        planet = OnClick.planet;
        if(planet.GetComponent<Outline>().enabled = true)
        {
            planet.GetComponent<Outline>().enabled = false;
        }
        Time.timeScale = 1f;
        script.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        input.SetActive(false);
    }
}
