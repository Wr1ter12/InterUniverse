using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAr : MonoBehaviour
{
    public float speed;
    public GameObject planet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(planet.transform.position, Vector3.down, speed * Time.deltaTime);
    }
}
