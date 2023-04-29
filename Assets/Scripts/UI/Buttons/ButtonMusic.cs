using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMusic : MonoBehaviour
{
    [SerializeField] AudioSource PlanetMarch;
    [SerializeField] AudioSource SunnyWiggle;
    [SerializeField] AudioSource UpToTheStars;
    [SerializeField] AudioSource LoFiSky;

    public void onClick()
    {
        if (PlanetMarch.isPlaying)
        {
            PlanetMarch.Stop();
            SunnyWiggle.Play();
        }
        else
        {
            if(SunnyWiggle.isPlaying)
            {
                SunnyWiggle.Stop();
                UpToTheStars.Play();
            }
            else 
            {
                if(UpToTheStars.isPlaying)
                {
                    LoFiSky.Play();
                    UpToTheStars.Stop();
                }
                else 
                {
                    if(LoFiSky.isPlaying)
                    {
                        LoFiSky.Stop();
                    }
                    else
                    {
                        PlanetMarch.Play();
                    }
                }
            }
        }
    }
}
