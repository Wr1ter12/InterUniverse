using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentS : MonoBehaviour
{
    public TextMeshProUGUI text;
    GameObject planet;

    void Update()
    {
        planet = OnClick.planet;
        if(ButtonSType.type == "ER")
        {
            text.text = (planet.transform.localScale.x / 2015).ToString();
        }
        else if(ButtonSType.type == "Km")
        {
            text.text = (planet.transform.localScale.x / 2015 * 6371).ToString();
        }
        else if(ButtonSType.type == "SR")
        {
            text.text = (planet.transform.localScale.x / 219635).ToString();
        }
    }
}
