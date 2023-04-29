using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDestroy : MonoBehaviour
{
    public List<GameObject> celestials;
    public GravitySystem gravitsys;
    public ButtonTrail buttontrail;
    [SerializeField] GameObject temparray;

    void Start()
    {
        celestials = new List<GameObject>();
        for(int i = 0; i < GameObject.FindGameObjectsWithTag("Celestial").Length; i++)
        {
            celestials.Add(GameObject.FindGameObjectsWithTag("Celestial")[i]);
        }
    }

    public void Celestials()
    {
        int i = GameObject.FindGameObjectsWithTag("Celestial").Length;
        celestials.Add(GameObject.FindGameObjectsWithTag("Celestial")[i - 1]);
    }

    public void onClick()
    {
        foreach(GameObject a in celestials)
        {
            if(a != null)
            {
                if(a.name == "Sun")
                {
                    gravitsys.celestials.Remove(a);
                    buttontrail.celestials.Remove(a);
                    try
                    {
                        temparray.GetComponent<TempArray>().stars.Remove(a);
                    }
                    catch{}
                    if(SaveManager.Instance != null)
                    {
                        SaveManager.Instance.RemoveObj(a.name);
                    }
                    a.SetActive(false);
                }
                else
                {
                    gravitsys.celestials.Remove(a);
                    buttontrail.celestials.Remove(a);
                    try
                    {
                        temparray.GetComponent<TempArray>().stars.Remove(a);
                    }
                    catch{}
                    if(SaveManager.Instance != null)
                    {
                        SaveManager.Instance.RemoveObj(a.name);
                    }
                    Destroy(a);
                }
            }
        }
    }
}
