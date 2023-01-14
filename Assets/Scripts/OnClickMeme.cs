using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OnClickMeme : MonoBehaviour
{
    public AudioSource Universal;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            Universal.Play(0);
        } 
    }
}
