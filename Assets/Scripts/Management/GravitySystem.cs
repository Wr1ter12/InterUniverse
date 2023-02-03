using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySystem : MonoBehaviour
{
    readonly float G = 6670f;
    public List<GameObject> celestials;
    public string newplanetName;
    float ax;

    // Start is called before the first frame update
    void Start()
    {
        celestials = new List<GameObject>();
        for(int i = 0; i < GameObject.FindGameObjectsWithTag("Celestial").Length; i++)
        {
            celestials.Add(GameObject.FindGameObjectsWithTag("Celestial")[i]);
        }

        InitialVelocity();
    }

    public void Celestials()
    {
        int i = GameObject.FindGameObjectsWithTag("Celestial").Length;
        celestials.Add(GameObject.FindGameObjectsWithTag("Celestial")[i - 1]);
        //DisableVelocity();
        InitialZero();
    }

    private void FixedUpdate()
    {
        Gravity();
    }

    void Gravity()
    {
        foreach(GameObject a in celestials)
        {
            if(a != null)
            {
                foreach(GameObject b in celestials)
                {
                    if(b != null)
                    {
                        if(!a.Equals(b))
                        {
                            if(a != null)
                            {
                                float m1 = a.GetComponent<Rigidbody>().mass;
                                float m2 = b.GetComponent<Rigidbody>().mass;
                                float r = Vector3.Distance(a.transform.position, b.transform.position);

                                a.GetComponent<Rigidbody>().AddForce((b.transform.position - a.transform.position).normalized * (G * (m1*m2) / (r * r)));
                            }
                        }
                    }
                }
            }
        }
    }

    void InitialVelocity()
    {
        foreach(GameObject a in celestials)
        {
            if(a != null)
            {
                foreach(GameObject b in celestials)
                {
                    if(b != null)
                    {
                        if(!a.Equals(b))
                        {
                            if(a != null)
                            {
                                float m1 = a.GetComponent<Rigidbody>().mass;
                                float m2 = b.GetComponent<Rigidbody>().mass;
                                float r = Vector3.Distance(a.transform.position, b.transform.position);
                                SpeedController speedController  = a.GetComponent<SpeedController>();
                                float currentspeed = speedController.speed;
                                ax = r / (Mathf.Sqrt(1 - Mathf.Pow(currentspeed, 2)));
                                float U = (2/r) - (1/ax);

                                a.GetComponent<Rigidbody>().velocity += -a.transform.right * Mathf.Sqrt((G * m2) * U);
                            }
                        }
                    }
                }
            }
        }
    }
    void DisableVelocity()
    {
        foreach(GameObject a in celestials)
        {
            if(a != null)
            {
                foreach(GameObject b in celestials)
                {
                    if(b != null)
                    {
                        if(!a.Equals(b))
                        {
                            if(a != null)
                            {   
                                a.GetComponent<Rigidbody>().velocity = Vector3.zero;
                            }
                        }
                    }
                }
            }
        }
        InitialVelocity();
    }
    void InitialZero()
    {
        newplanetName = ButtonInputCreate.name;
        foreach(GameObject a in celestials)
        {
            if(a != null)
            {
                foreach(GameObject b in celestials)
                {
                    if(b != null)
                    {
                        if(!a.Equals(b))
                        {
                            if(a != null)
                            {
                                if(b.name == newplanetName)
                                {
                                    float m1 = a.GetComponent<Rigidbody>().mass;
                                    float m2 = b.GetComponent<Rigidbody>().mass;
                                    float r = Vector3.Distance(a.transform.position, b.transform.position);
                                    SpeedController speedController  = a.GetComponent<SpeedController>();
                                    float currentspeed = speedController.speed;
                                    ax = r / (Mathf.Sqrt(1 - Mathf.Pow(currentspeed, 2)));
                                    float U = (2/r) - (1/ax);

                                    a.GetComponent<Rigidbody>().velocity += -a.transform.right * Mathf.Sqrt((G * m2) * U);
                                }
                                else
                                {
                                    if(a.name == newplanetName)
                                    {
                                        if(b.name != newplanetName)
                                        {
                                            float m1 = a.GetComponent<Rigidbody>().mass;
                                            float m2 = b.GetComponent<Rigidbody>().mass;
                                            float r = Vector3.Distance(a.transform.position, b.transform.position);
                                            SpeedController speedController  = a.GetComponent<SpeedController>();
                                            float currentspeed = speedController.speed;
                                            ax = r / (Mathf.Sqrt(1 - Mathf.Pow(currentspeed, 2)));
                                            float U = (2/r) - (1/ax);

                                            a.GetComponent<Rigidbody>().velocity += -a.transform.right * Mathf.Sqrt((G * m2) * U);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
