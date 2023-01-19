using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonInputCreate : MonoBehaviour
{
    GameObject obj;
    public GravitySystem gravitsys;
    public ButtonTrail buttontrail;
    public GameObject input;
    [SerializeField] private TMP_InputField m_inputField_name;
    [SerializeField] private TMP_InputField m_inputField_s;
    [SerializeField] private TMP_InputField m_inputField_m;
    [SerializeField] private TMP_InputField m_inputField_ax;
    [SerializeField] private TMP_InputField m_inputField_pos;
    [SerializeField] private Behaviour script;
    public GameObject planet;
    float axes;
    public GameObject sun;
    public GameObject star;
    public static string name;
    public GameObject camera;
    GameObject newplanet;
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
        string planetname = m_inputField_name.text;
        float scales = float.Parse(m_inputField_s.text) * 2015;
        float masses = float.Parse(m_inputField_m.text);
        if(float.Parse(m_inputField_ax.text) >= 2f)
        {
            axes = 0.1f;
        }
        else
        {
            axes = 2 - float.Parse(m_inputField_ax.text);
        }
        if(m_inputField_pos.text == "")
        {
            if(ButtonType.type == "planet")
            {
                newplanet = Instantiate(planet, new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z), Quaternion.Euler(0f, 0f, 0f));
            }
            else if(ButtonType.type == "star")
            {
                newplanet = Instantiate(star, new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z), Quaternion.Euler(0f, 0f, 0f));
            }
        }
        else
        {
            float pos = float.Parse(m_inputField_pos.text) * 15100;
            float sunpos = sun.transform.position.x;
            if(ButtonType.type == "planet")
            {
                newplanet = Instantiate(planet, new Vector3(sunpos, 0, pos), Quaternion.Euler(0f, 0f, 0f));
            }
            else if(ButtonType.type == "star")
            {
                newplanet = Instantiate(star, new Vector3(sunpos, 0, pos), Quaternion.Euler(0f, 0f, 0f));
            }
        }
        newplanet.name = planetname;
        newplanet.gameObject.transform.localScale = new Vector3(scales, scales, scales);
        newplanet.GetComponent<Rigidbody>().mass = masses;
        newplanet.GetComponent<SpeedController>().speed = axes;
        name = newplanet.name;
        gravitsys.GetComponent<GravitySystem>().Celestials();
        buttontrail.GetComponent<ButtonTrail>().Celestials();
        newplanet.SetActive(true);
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
