using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorTerm : MonoBehaviour
{
    [SerializeField] int type;
    [SerializeField] GameObject tutor;
    [SerializeField] GameObject text1;

    public void OnMouseOver()
    {
        if(type == 0)
        {
            tutor.SetActive(true);
            text1.SetActive(true);
        }
    }

    public void OnMouseExit()
    {
        tutor.SetActive(false);
        text1.SetActive(false);
    }
}
