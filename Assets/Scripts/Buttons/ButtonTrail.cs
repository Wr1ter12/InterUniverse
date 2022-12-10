using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrail : MonoBehaviour
{
    public List<GameObject> celestials;

    void Start()
    {
        celestials = new List<GameObject>();
        for(int i = 0; i < GameObject.FindGameObjectsWithTag("Celestial").Length; i++)
        {
            celestials.Add(GameObject.FindGameObjectsWithTag("Celestial")[i]);
        }
    }

    public void Celestials()
    {
        int i = GameObject.FindGameObjectsWithTag("Celestial").Length;
        celestials.Add(GameObject.FindGameObjectsWithTag("Celestial")[i - 1]);
    }

    public void onClick()
    {
        foreach(GameObject a in celestials)
        {
            if(a.TryGetComponent<TrailRenderer>(out var comp))
            {
                if(a.GetComponent<TrailRenderer>().enabled==false)
            {
                a.GetComponent<TrailRenderer>().enabled=true;
            }
            else
            {
                a.GetComponent<TrailRenderer>().enabled=false;
            }
            }
        }
    }
}
