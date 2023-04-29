using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    void Start()
    {
        GameObject array = GameObject.Find("TempArray");
        array.GetComponent<TempArray>().stars.Add(gameObject);
    }
}
