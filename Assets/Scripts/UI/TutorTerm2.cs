using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorTerm2 : MonoBehaviour
{
    [SerializeField] int type;
    [SerializeField] GameObject tutor;
    [SerializeField] GameObject text1;
    [SerializeField] GameObject text2;
    [SerializeField] GameObject text3;
    [SerializeField] GameObject text4;
    [SerializeField] GameObject text5;
    [SerializeField] GameObject text6;
    [SerializeField] GameObject text7;
    [SerializeField] GameObject text8;
    [SerializeField] GameObject text9;
    [SerializeField] GameObject text10;
    [SerializeField] GameObject text11;
    [SerializeField] GameObject text12;

    public void OnMouseOver()
    {
        if(type == 0)
        {
            text1.SetActive(true);
        }
        else if (type == 1)
        {
            switch(GetComponent<TextMeshProUGUI>().text)
            {
                case "Earth":
                    text2.SetActive(true);
                    break;
                case "Sun":
                    text3.SetActive(true);
                    break;
                case "Mercury":
                    text4.SetActive(true);
                    break;
                case "Venus":
                    text5.SetActive(true);
                    break;
                case "Mars":
                    text6.SetActive(true);
                    break;
                case "Jupiter":
                    text7.SetActive(true);
                    break;
                case "Saturn":
                    text8.SetActive(true);
                    break;
                case "Uranus":
                    text9.SetActive(true);
                    break;
                case "Neptune":
                    text10.SetActive(true);
                    break;
                case "Pluto":
                    text11.SetActive(true);
                    break;
                case "Moon":
                    text12.SetActive(true);
                    break;
                default:
                    break;
            }    
        }
    }

    public void OnMouseExit()
    {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        text5.SetActive(false);
        text6.SetActive(false);
        text7.SetActive(false);
        text8.SetActive(false);
        text9.SetActive(false);
        text10.SetActive(false);
        text11.SetActive(false);
        text12.SetActive(false);
    }
}
