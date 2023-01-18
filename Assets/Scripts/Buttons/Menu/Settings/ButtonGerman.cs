using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGerman : MonoBehaviour
{
    public void OnClick()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("German");
    }
}
