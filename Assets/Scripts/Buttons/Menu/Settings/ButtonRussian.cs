using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRussian : MonoBehaviour
{
    public void OnClick()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Russian");
    }
}
