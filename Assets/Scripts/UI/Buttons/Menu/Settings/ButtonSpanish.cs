using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpanish : MonoBehaviour
{
    public void OnClick()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Spanish");
    }
}
