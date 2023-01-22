using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDelete : MonoBehaviour
{
    public GameObject input;
    [SerializeField] private Behaviour script;
    public GameObject planet;
    public GravitySystem gravitsys;
    public ButtonTrail buttontrail;

    public void onClick()
    {
        planet = OnClick.planet;
        if(planet.name == "Mercury" || planet.name == "Sun")
        {
            gravitsys.celestials.Remove(planet);
            buttontrail.celestials.Remove(planet);
            planet.SetActive(false);
        }
        else
        {
            gravitsys.celestials.Remove(planet);
            buttontrail.celestials.Remove(planet);
            Destroy(planet);
        }
        script.enabled = true;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        input.SetActive(false);
    }
}
