using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrail : MonoBehaviour
{
    public List<GameObject> celestials;
    bool trail = true;

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
        if(trail == true)
        {
            foreach(GameObject a in celestials)
            {
                if(a != null)
                {
                    if(a.TryGetComponent<TrailRenderer>(out var comp))
                    {
                        a.GetComponent<TrailRenderer>().enabled=false;
                    }   
                }
            }
            trail = false;
        }
        else
        {
            foreach(GameObject a in celestials)
            {
                if(a != null)
                {
                    if(a.TryGetComponent<TrailRenderer>(out var comp))
                    {
                        a.GetComponent<TrailRenderer>().enabled=true;
                    }   
                }
            }
            trail = true;
        }
    }
}
