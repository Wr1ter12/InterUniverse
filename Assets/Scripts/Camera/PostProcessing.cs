using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessing : MonoBehaviour
{
    public GameObject volume;

    // Update is called once per frame
    void Update()
    {
        if(ButtonPostProcessing.postprocess == false)
        {
            volume.SetActive(false);
        }
        else
        {
            volume.SetActive(true);
        }
    }
}
