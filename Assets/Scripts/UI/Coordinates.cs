using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coordinates : MonoBehaviour
{
    public GameObject camera;

    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = (Mathf.Round((camera.transform.position.x / 15100) * 100f) / 100f) + "; \n" + (Mathf.Round((camera.transform.position.x / 15100) * 100f) / 100f) + "; \n" + (Mathf.Round((camera.transform.position.z / 15100) * 100f) / 100f) + ";";
    }
}
