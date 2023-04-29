using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonConstTrail : MonoBehaviour
{
    public List<GameObject> celestials;
    bool trail = true;
    [SerializeField] ButtonTrail buttontrail;

    void Update()
    {
        celestials = buttontrail.celestials;
    }

    public void onClick()
    {
        if(trail == true)
        {
            foreach(GameObject a in celestials)
            {
                if(a != null)
                {
                    if(a.TryGetComponent<LineRenderer>(out var comp))
                    {
                        if(a.GetComponent<LineRenderer>() != null)
                        {
                            a.GetComponent<LineRenderer>().enabled=false;
                        }
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
                    if(a.TryGetComponent<LineRenderer>(out var comp))
                    {
                        if(a.GetComponent<LineRenderer>() != null)
                        {
                            a.GetComponent<LineRenderer>().enabled=true;
                        }
                    }   
                }
            }
            trail = true;
        }
    }
}
