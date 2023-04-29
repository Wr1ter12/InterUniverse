using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    float dist;
    [SerializeField] float temp;
    GameObject array;

    void Start()
    {
        array = GameObject.Find("TempArray");
    }

    void Update()
    {
        foreach(GameObject a in array.GetComponent<TempArray>().stars)
        {
            dist = Vector3.Distance(a.transform.position, transform.position);
        }
        if(array.GetComponent<TempArray>().stars.Count != 0)
        {
            temp = -230 + 15100 / dist * 250;
        }   
        else
        {
            temp = -230;
        }
        if(temp >= 0)
        {
            GetComponent<Renderer>().material.color = new Color(1f, 1f - temp / 1000, 1f - temp / 1000);
        }
        else
        {
            GetComponent<Renderer>().material.color = new Color(1f - -temp / 1000, 1 - -temp / 1000, 1f);
        }   
    }
}
