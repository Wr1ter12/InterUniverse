using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnglish : MonoBehaviour
{
    public void OnClick()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("English");
    }
}
