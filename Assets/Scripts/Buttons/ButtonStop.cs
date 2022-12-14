using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonStop : MonoBehaviour
{
    public GameObject Sun;
    // Start is called before the first frame update
    public void onClick()
    {
        Sun.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    }
}
