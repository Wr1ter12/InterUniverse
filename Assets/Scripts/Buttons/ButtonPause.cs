using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonPause : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void onClick()
    {

        if (Time.timeScale != 0.0f)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }

    public void Update() {
        if (Time.timeScale == 0.0f)
        {
            text.text = ">";
        }
        else
        {
            text.text = "II";
        }
    }
}
