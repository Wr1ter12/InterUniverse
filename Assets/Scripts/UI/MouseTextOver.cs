using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MouseTextOver : MonoBehaviour
{
    [SerializeField] string text;
    [SerializeField] GameObject mousetext;

    public void OnMouseOver()
    {
        if(mousetext.activeSelf == false)
        {
            mousetext.SetActive(true);
            mousetext.GetComponent<TextMeshProUGUI>().text = text;
        }
    }

    public void OnMouseExit()
    {
        if(mousetext.activeSelf == true)
        {
            mousetext.SetActive(false);
        }
    }
}
