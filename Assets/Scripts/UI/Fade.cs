using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    void Awake()
    {
        gameObject.GetComponent<Animator>().SetTrigger("fadeOut");
    }
}
