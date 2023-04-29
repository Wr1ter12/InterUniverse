using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorTerm : MonoBehaviour
{
    [SerializeField] int type;
    [SerializeField] GameObject text1;

    public void OnMouseOver()
    {
        if(type == 0)
        {
            text1.SetActive(true);
        }
    }

    public void OnMouseExit()
    {
        text1.SetActive(false);
    }
}
