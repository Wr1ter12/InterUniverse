using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonStop : MonoBehaviour
{
    public GameObject Sun;
    public GameObject button;
    public GameObject text1;
    public GameObject text2;

    public bool freeze = false;
    // Start is called before the first frame update
    public void onClick()
    {
        if(freeze == false)
        {
            Sun.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            freeze = true;
            text1.SetActive(false);
            text2.SetActive(true);
        }
        else
        {
            Sun.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            Sun.transform.position = new Vector3(Sun.transform.position.x-0.001f, Sun.transform.position.y-0.001f, Sun.transform.position.z-0.001f);
            freeze = false;
            text1.SetActive(true);
            text2.SetActive(false);
        }
    }
}
