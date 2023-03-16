using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlashlight : MonoBehaviour
{
    [SerializeField] GameObject light;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            if(light.activeSelf == false)
            {
                light.SetActive(true);
            }
            else
            {
                light.SetActive(false);
            }
        }
    }
}
