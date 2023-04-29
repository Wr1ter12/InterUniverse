using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMType : MonoBehaviour
{
    public static string type;
    [SerializeField] GameObject text1;
    [SerializeField] GameObject text2;
    [SerializeField] GameObject text3;

    void Start()
    {
        type = "EM";
    }

    public void InputType(int value)
    {
        if(value == 0)
        {
            type = "EM";
        }
        if(value == 1)
        {
            type = "T";
        }
        if(value == 2)
        {
            type = "SM";
        }
    }

    public void OnMouseOver()
    {
        if(type == "EM")
        {
            text1.SetActive(true);
        }
        if(type == "T")
        {
            text2.SetActive(true);
        }
        if(type == "SM")
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
