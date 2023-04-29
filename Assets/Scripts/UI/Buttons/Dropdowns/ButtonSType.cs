using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSType : MonoBehaviour
{
    public static string type;
    [SerializeField] GameObject text1;
    [SerializeField] GameObject text2;
    [SerializeField] GameObject text3;

    void Start()
    {
        type = "ER";
    }

    public void InputType(int value)
    {
        if(value == 0)
        {
            type = "ER";
        }
        if(value == 1)
        {
            type = "Km";
        }
        if(value == 2)
        {
            type = "SR";
        }
    }

    public void OnMouseOver()
    {
        if(type == "ER")
        {
            text1.SetActive(true);
        }
        if(type == "Km")
        {
            text2.SetActive(true);
        }
        if(type == "SR")
        {
            text3.SetActive(true);
        }
    }

    public void OnMouseExit()
    {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
    }
}
