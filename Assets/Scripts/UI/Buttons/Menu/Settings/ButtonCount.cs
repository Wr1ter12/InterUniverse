using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCount : MonoBehaviour
{
    float count;
    public string countKey = "Count";
    public float CurrentCount { get; set; }
    public Slider slider;

    private void Awake()
    {
        CurrentCount = PlayerPrefs.GetFloat(countKey);
        slider.value = CurrentCount;
        count = CurrentCount;
    }

    public void SetSliderValue() {
        count = slider.value;
        Debug.Log(count);
        PlayerPrefs.SetFloat(countKey, count);
    }
}
