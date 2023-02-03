using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha0))
        {
            Time.timeScale = 0.0f;
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Time.timeScale = 1.0f;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Time.timeScale = 2.0f;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            Time.timeScale = 3.0f;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            Time.timeScale = 4.0f;
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            Time.timeScale = 5.0f;
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            Time.timeScale = 6.0f;
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            Time.timeScale = 7.0f;
        }
        if (Input.GetKey(KeyCode.Alpha8))
        {
            Time.timeScale = 8.0f;
        }
        if (Input.GetKey(KeyCode.Alpha9))
        {
            Time.timeScale = 9.0f;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            Time.timeScale = 10.0f;
        }
        if (Input.GetKey("[2]"))
        {
            Time.timeScale = 0.5f;
        }
        if (Input.GetKey("[3]"))
        {
            Time.timeScale = 0.33f;
        }
        if (Input.GetKey("[4]"))
        {
            Time.timeScale = 0.25f;
        }
        if (Input.GetKey("[5]"))
        {
            Time.timeScale = 0.2f;
        }
    }
}
