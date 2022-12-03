using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySystem : MonoBehaviour
{
    readonly float G = 6670f;
    public float ax = 1.75f;
    GameObject[] celestials;
    public string newplanetName;

    // Start is called before the first frame update
    void Start()
    {
        celestials = GameObject.FindGameObjectsWithTag("Celestial");

        InitialVelocity();
    }

    public void Celestials()
    {
        celestials = GameObject.FindGameObjectsWithTag("Celestial");

        InititalZero();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Gravity();
    }

    void Gravity()
    {
        foreach(GameObject a in celestials)
        {
            foreach(GameObject b in celestials)
            {
                if(!a.Equals(b))
                {
                    float m1 = a.GetComponent<Rigidbody>().mass;
                    float m2 = b.GetComponent<Rigidbody>().mass;
                    float r = Vector3.Distance(a.transform.position, b.transform.position);

                    a.GetComponent<Rigidbody>().AddForce((b.transform.position - a.transform.position).normalized * (G * (m1*m2) / (r * r)));
                }
            }
        }
    }

    void InitialVelocity()
    {
        foreach(GameObject a in celestials)
        {
            foreach(GameObject b in celestials)
            {
                if(!a.Equals(b))
                {
                    float m1 = a.GetComponent<Rigidbody>().mass;
                    float m2 = b.GetComponent<Rigidbody>().mass;
                    float r = Vector3.Distance(a.transform.position, b.transform.position);
                    SpeedController speedController  = a.GetComponent<SpeedController>();
                    float currentspeed = speedController.speed;
                    float U = (2/r) * (1/(ax * currentspeed));

                    a.GetComponent<Rigidbody>().velocity += -a.transform.right * Mathf.Sqrt((G * m2) * U);
                }
            }
        }
    }
    void InititalZero()
    {
        foreach(GameObject a in celestials)
        {
            foreach(GameObject b in celestials)
            {
                if(!a.Equals(b))
                {
                    newplanetName = ButtonInputCreate.name;
                    if(a.name == newplanetName)
                    {
                        float m1 = a.GetComponent<Rigidbody>().mass;
                        float m2 = b.GetComponent<Rigidbody>().mass;
                        float r = Vector3.Distance(a.transform.position, b.transform.position);
                        SpeedController speedController  = a.GetComponent<SpeedController>();
                        float currentspeed = speedController.speed;
                        float U = (2/r) * (1/(ax * currentspeed));

                        a.GetComponent<Rigidbody>().velocity += -a.transform.right * Mathf.Sqrt((G * m2) * U);
                    }
                }
            }
        }
    }
}
