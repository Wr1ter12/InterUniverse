using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentName : MonoBehaviour
{
    public TextMeshProUGUI text;
    GameObject planet;

    void Update()
    {
        planet = OnClick.planet;
        text.text = planet.name;
    }
}
