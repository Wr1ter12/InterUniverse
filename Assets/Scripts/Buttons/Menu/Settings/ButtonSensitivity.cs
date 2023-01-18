using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSensitivity : MonoBehaviour
{
    float sensitivity;
    public string senseKey = "Sense";
    public float CurrentSense { get; set; }
    public Slider slider;

    private void Awake()
    {
        CurrentSense = PlayerPrefs.GetFloat(senseKey);
        slider.value = CurrentSense;
        sensitivity = CurrentSense;
    }

    public void SetSliderValue() {
        sensitivity = slider.value;
        Debug.Log(sensitivity);
        PlayerPrefs.SetFloat(senseKey, sensitivity);
    }
}
