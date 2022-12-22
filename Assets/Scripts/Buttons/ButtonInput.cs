using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonInput : MonoBehaviour
{
    GameObject obj;
    public GameObject input;
    [SerializeField] private TMP_InputField m_inputField_s;
    [SerializeField] private TMP_InputField m_inputField_m;
    [SerializeField] private TMP_InputField m_inputField_ax;
    [SerializeField] private Behaviour script;
    public GameObject planet;
    float scales;
    float masses;
    float axes;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("ButtonTime");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        planet = OnClick.planet;
        if(m_inputField_s.text == "") {scales = planet.transform.localScale.x;}
        else {scales = float.Parse(m_inputField_s.text) * 2015;}

        if(m_inputField_m.text == "") {masses = planet.GetComponent<Rigidbody>().mass;}
        else {masses = float.Parse(m_inputField_m.text);}
        
        if(m_inputField_ax.text == "") {axes = planet.GetComponent<SpeedController>().speed;}
        else {axes = 2 - float.Parse(m_inputField_ax.text);}

        planet.gameObject.transform.localScale = new Vector3(scales, scales, scales);
        planet.GetComponent<Rigidbody>().mass = masses;
        planet.GetComponent<SpeedController>().speed = axes;
        Cursor.lockState = CursorLockMode.Confined;
        if(obj.GetComponent<TMP_Dropdown>().value == 0)
        {
            Time.timeScale = 1.0f;
        }
        if(obj.GetComponent<TMP_Dropdown>().value == 1)
        {
            Time.timeScale = 2.0f;
        }
        if(obj.GetComponent<TMP_Dropdown>().value == 2)
        {
            Time.timeScale = 3.0f;
        }
        if(obj.GetComponent<TMP_Dropdown>().value == 3)
        {
            Time.timeScale = 4.0f;
        }
        if(obj.GetComponent<TMP_Dropdown>().value == 4)
        {
            Time.timeScale = 5.0f;
        }
        if(obj.GetComponent<TMP_Dropdown>().value == 5)
        {
            Time.timeScale = 25.0f;
        }
        if(obj.GetComponent<TMP_Dropdown>().value == 6)
        {
            Time.timeScale = 0.5f;
        }
        if(obj.GetComponent<TMP_Dropdown>().value == 7)
        {
            Time.timeScale = 0.33f;
        }
        if(obj.GetComponent<TMP_Dropdown>().value == 8)
        {
            Time.timeScale = 0.25f;
        }
        if(obj.GetComponent<TMP_Dropdown>().value == 9)
        {
            Time.timeScale = 0.2f;
        }
        script.enabled = true;
        input.SetActive(false);
    }
}
