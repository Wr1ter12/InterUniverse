using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentM : MonoBehaviour
{
    public TextMeshProUGUI text;
    GameObject planet;

    void Update()
    {
        planet = OnClick.planet;
        if(ButtonMType.type == "EM")
        {
            text.text = planet.GetComponent<Rigidbody>().mass.ToString();
        }
        else if(ButtonMType.type == "T")
        {
            text.text = (planet.GetComponent<Rigidbody>().mass * 5972000000000000).ToString();
        }
        else if(ButtonMType.type == "SM")
        {
            text.text = (planet.GetComponent<Rigidbody>().mass / 333000).ToString();
        }
    }
}
