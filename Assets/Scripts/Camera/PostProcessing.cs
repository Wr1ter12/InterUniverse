using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ButtonPostProcessing.postprocess == false)
        {
            GetComponent<PostProcessVolume>().enabled = false;
        }
        else
        {
            GetComponent<PostProcessVolume>().enabled = true;
        }
    }
}
