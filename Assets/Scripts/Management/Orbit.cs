using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    LineRenderer Line;
    [SerializeField] GameObject Sun;
    [SerializeField] float ThetaScale = 0.01f;
    [SerializeField] float radius = 3f;
    private int Size;
    private float Theta = 0f;

    void Start()
    {
        Line = GetComponent<LineRenderer>();
        try {Sun = FindObjectOfType<Sun>().gameObject;}
        catch {}
    }

    void Update()
    {
        Theta = 0f;
        if(Sun != null)
        {
            if(Sun.activeSelf == true)
            {
                if(Sun.transform.position.x < 5000)
                {
                    radius = Vector3.Distance(transform.position, Sun.transform.position);
                    Size = (int)((1f / ThetaScale) + 1f);
                    Line.SetVertexCount(Size);
                    for (int i = 0; i < Size; i++) {
                        Theta += (2.0f * Mathf.PI * ThetaScale);
                        float x = radius * Mathf.Cos(Theta);
                        float y = radius * Mathf.Sin(Theta);
                        Line.SetPosition(i, new Vector3(y, 0, x));
                    }
                }
                else
                {
                    if(Line != null)
                    {
                        Line.SetVertexCount(0);
                        Destroy(GetComponent<LineRenderer>());
                    } 
                }
            }
            else
            {
                if(Line != null)
                {
                    Line.SetVertexCount(0);
                    Destroy(GetComponent<LineRenderer>());
                } 
            }
        }
        else
        {
            if(Line != null)
            {
                Line.SetVertexCount(0);
                Destroy(GetComponent<LineRenderer>());
            } 
        }
    }
}
