using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessing : MonoBehaviour
{
    public GameObject volume;
    public int save;

    private void Start()
    {
        save = PlayerPrefs.GetInt("post", save);
        if(save == 1)
        {
            ButtonPostProcessing.postprocess = true;
            volume.SetActive(true);
        }
        else
        {
            ButtonPostProcessing.postprocess = false;
            volume.SetActive(false);
        }
    }

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
