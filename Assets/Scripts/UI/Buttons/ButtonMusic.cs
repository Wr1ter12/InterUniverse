using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMusic : MonoBehaviour
{
    public AudioSource PlanetMarch;
    public AudioSource SunnyWiggle;
    public AudioSource UpToTheStars;

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
                UpToTheStars.Stop();
                }
                else 
                {
                PlanetMarch.Play();
                }
            }
        }
    }
}
