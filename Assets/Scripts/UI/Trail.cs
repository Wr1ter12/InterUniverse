using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
    int curwidth;
    [SerializeField] float dist;

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(Camera.main.transform.position, transform.position);
        GetComponent<TrailRenderer>().widthMultiplier = curwidth + dist / 500;
        if(gameObject.GetComponent<LineRenderer> () != null)
        {
            GetComponent<LineRenderer>().widthMultiplier = curwidth + dist / 500;
        }
    }
}
