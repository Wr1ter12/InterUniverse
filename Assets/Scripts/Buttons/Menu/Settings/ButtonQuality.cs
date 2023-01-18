using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonQuality : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int CurrentLevel { get; set; }
    int level = 3;
    string levelKey = "Level";

    private void Awake()
    {
        CurrentLevel = PlayerPrefs.GetInt(levelKey);
        level = CurrentLevel;
    }

    void Update ()
    {
        if(level == 0)
        {
            text.text = "Fastest";
        }
        else if (level == 1)
        {
            text.text = "Fast";
        }
        else if (level == 2)
        {
            text.text = "Medium";
        }
        else if (level == 3)
        {
            text.text = "High";
        }
        else if (level == 4)
        {
            text.text = "Very High";
        }
        else if (level == 5)
        {
            text.text = "Ultra";
        }
    }
    public void OnClick()
    {
        level += 1;
        if(level > 5)
        {
            level = 0;
            QualitySettings.SetQualityLevel(level, true);
        }
        else
        {
            QualitySettings.SetQualityLevel(level, true);
        }
        PlayerPrefs.SetInt(levelKey, level);
    }
}
