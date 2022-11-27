using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrail : MonoBehaviour
{
    public GameObject Mercury;
    public GameObject Venera;
    public GameObject Earth;
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Uran;
    public GameObject Neptune;
    public GameObject Pluto;

    public void onClick()
    {
        if (Earth.GetComponent<TrailRenderer>().enabled==true) {
            Mercury.GetComponent<TrailRenderer>().enabled=false;
            Venera.GetComponent<TrailRenderer>().enabled=false; 
            Earth.GetComponent<TrailRenderer>().enabled=false; 
            Mars.GetComponent<TrailRenderer>().enabled=false; 
            Jupiter.GetComponent<TrailRenderer>().enabled=false; 
            Saturn.GetComponent<TrailRenderer>().enabled=false; 
            Uran.GetComponent<TrailRenderer>().enabled=false; 
            Neptune.GetComponent<TrailRenderer>().enabled=false; 
            Pluto.GetComponent<TrailRenderer>().enabled=false;  
        } 
        else {
            Mercury.GetComponent<TrailRenderer>().enabled=true;
            Venera.GetComponent<TrailRenderer>().enabled=true; 
            Earth.GetComponent<TrailRenderer>().enabled=true; 
            Mars.GetComponent<TrailRenderer>().enabled=true; 
            Jupiter.GetComponent<TrailRenderer>().enabled=true; 
            Saturn.GetComponent<TrailRenderer>().enabled=true; 
            Uran.GetComponent<TrailRenderer>().enabled=true; 
            Neptune.GetComponent<TrailRenderer>().enabled=true; 
            Pluto.GetComponent<TrailRenderer>().enabled=true;  
        }
    }
}
