using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextName : MonoBehaviour
{
    public TextMeshPro name;
    int save;
    float dist;

    void Start()
    {
        save = PlayerPrefs.GetInt("names", save);
        if(save == 0)
        {
            name.enabled = false;
        }
    }

    void Update()
    {
        if(name != null)
        {
            name.text = gameObject.name;
            name.transform.LookAt(Camera.main.transform.position);
            name.transform.Rotate(0, 180, 0);
        }
    }
}
