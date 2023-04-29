using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempArray : MonoBehaviour
{
    public List<GameObject> stars;

    void Start()
    {
        stars = new List<GameObject>();
    }
}
