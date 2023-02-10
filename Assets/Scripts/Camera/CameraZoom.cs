using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            transform.position += transform.forward * Input.GetAxis("Mouse ScrollWheel") * 6000;
        }
    }
}
