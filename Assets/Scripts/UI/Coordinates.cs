using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coordinates : MonoBehaviour
{
    public GameObject camera;
    int save;

    void Start()
    {
        save = PlayerPrefs.GetInt("coords", save);
        if(save == 0)
        {
            gameObject.SetActive(false);
        }
    }

    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = (Mathf.Round((camera.transform.position.x / 15100) * 100f) / 100f) + "; \n" + (Mathf.Round((camera.transform.position.x / 15100) * 100f) / 100f) + "; \n" + (Mathf.Round((camera.transform.position.z / 15100) * 100f) / 100f) + ";";
    }
}
