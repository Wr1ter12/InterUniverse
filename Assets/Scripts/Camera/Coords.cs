using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coords : MonoBehaviour
{
    public int save;

    private void Start()
    {
        save = PlayerPrefs.GetInt("coords", save);
        if(save == 1)
        {
            ButtonCoordinates.coords = true;
        }
        else
        {
            ButtonCoordinates.coords = false;
        }
    }
}
