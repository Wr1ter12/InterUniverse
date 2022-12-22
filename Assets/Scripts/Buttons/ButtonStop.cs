using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonStop : MonoBehaviour
{
    public GameObject Sun;
    public TextMeshProUGUI text;
    public bool freeze = false;
    // Start is called before the first frame update
    public void onClick()
    {
        if(freeze == false)
        {
            Sun.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            freeze = true;
        }
        else
        {
            Sun.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            Sun.transform.position = new Vector3(Sun.transform.position.x-0.001f, Sun.transform.position.y-0.001f, Sun.transform.position.z-0.001f);
            freeze = false;
        }
    }
    
    public void Update()
    {
        if(freeze == false)
        {
            text.text = "Stop";
        }
        else
        {
            text.text = "Start";
        }
    }
}
