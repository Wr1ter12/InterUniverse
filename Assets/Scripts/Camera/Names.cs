using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Names : MonoBehaviour
{
    public int save;

    private void Start()
    {
        save = PlayerPrefs.GetInt("names", save);
        if(save == 1)
        {
            ButtonNames.names = true;
        }
        else
        {
            ButtonNames.names = false;
        }
    }
}
