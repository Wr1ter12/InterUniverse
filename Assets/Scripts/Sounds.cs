using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource Click1;
    public AudioSource Click2;
    // Start is called before the first frame update
    public void onClick()
    {
        Click1.Play();
    }
}
