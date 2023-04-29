using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonInputCreate : MonoBehaviour
{
    GameObject obj;
    public GravitySystem gravitsys;
    public GameObject buttontrail;
    public ButtonDestroy buttondestroy;
    public GameObject input;
    [SerializeField] private TMP_InputField m_inputField_name;
    [SerializeField] private TMP_InputField m_inputField_s;
    [SerializeField] private TMP_InputField m_inputField_m;
    [SerializeField] private TMP_InputField m_inputField_ax;
    [SerializeField] private TMP_InputField m_inputField_pos;
    [SerializeField] private Behaviour script;
    public GameObject planet;
    float axes;
    float pos;
    float scales;
    float masses;
    string planetname;
    public GameObject sun;
    public GameObject star;
    public GameObject blackhole;
    public GameObject whitehole;
    public GameObject asteroid;
    public static string name;
    public GameObject camera;
    GameObject newplanet;
    [SerializeField] GameObject Error;
    [SerializeField] GameObject ErrorField;
    [SerializeField] GameObject ErrorName;

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
        GameObject naming = GameObject.Find(m_inputField_name.text);
        if(naming == null)
        {
            try 
            {
                planetname = m_inputField_name.text;
                if(ButtonSType.type == "ER")
                {
                    scales = float.Parse(m_inputField_s.text) * 2015;
                }
                else if(ButtonSType.type == "Km")
                {
                    scales = float.Parse(m_inputField_s.text) * 2015 / 6371;
                }
                else if(ButtonSType.type == "SR")
                {
                    scales = float.Parse(m_inputField_s.text) * 219635;
                }
                if(ButtonMType.type == "EM")
                {
                    masses = float.Parse(m_inputField_m.text);
                }
                else if(ButtonMType.type == "T")
                {
                    masses = float.Parse(m_inputField_m.text) / 5972000000000000;
                }
                else if(ButtonMType.type == "SM")
                {
                    masses = float.Parse(m_inputField_m.text) * 333000;
                }
                if(float.Parse(m_inputField_ax.text) >= 1f)
                {
                    axes = 0.9f;
                }
                else if(float.Parse(m_inputField_ax.text) < 0f) 
                {
                    axes = 0f;
                }
                else
                {
                    axes = float.Parse(m_inputField_ax.text);
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
                    else if(ButtonType.type == "blackhole")
                    {
                        newplanet = Instantiate(blackhole, new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z), Quaternion.Euler(90f, 0f, 0f));
                    }
                    else if(ButtonType.type == "whitehole")
                    {
                        newplanet = Instantiate(whitehole, new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z), Quaternion.Euler(90f, 0f, 0f));
                    }
                    else if(ButtonType.type == "asteroid")
                    {
                        newplanet = Instantiate(asteroid, new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z), Quaternion.Euler(0f, 0f, 0f));
                    }
                }
                else
                {
                    if(ButtonPosType.type == "AU")
                    {
                        pos = float.Parse(m_inputField_pos.text) * 15100;
                    }
                    else if(ButtonPosType.type == "Km")
                    {
                        pos = float.Parse(m_inputField_pos.text) * 15100 * 0.00000000668459f;
                    }
                    float sunpos = sun.transform.position.x;

                    if(ButtonType.type == "planet")
                    {
                        newplanet = Instantiate(planet, new Vector3(sunpos, 0, pos), Quaternion.Euler(0f, 0f, 0f));
                    }
                    else if(ButtonType.type == "star")
                    {
                        newplanet = Instantiate(star, new Vector3(sunpos, 0, pos), Quaternion.Euler(0f, 0f, 0f));
                    }
                    else if(ButtonType.type == "blackhole")
                    {
                        newplanet = Instantiate(blackhole, new Vector3(sunpos, 0, pos), Quaternion.Euler(90f, 0f, 0f));
                    }
                    else if(ButtonType.type == "whitehole")
                    {
                        newplanet = Instantiate(whitehole, new Vector3(sunpos, 0, pos), Quaternion.Euler(90f, 0f, 0f));
                    }
                    else if(ButtonType.type == "asteroid")
                    {
                        newplanet = Instantiate(asteroid, new Vector3(sunpos, 0, pos), Quaternion.Euler(0f, 0f, 0f));
                    }
                }
                newplanet.name = planetname;
                newplanet.gameObject.transform.localScale = new Vector3(scales, scales, scales);
                newplanet.GetComponent<Rigidbody>().mass = masses;
                newplanet.GetComponent<SpeedController>().speed = axes;
                name = newplanet.name;
                gravitsys.GetComponent<GravitySystem>().Celestials();
                buttontrail.GetComponent<ButtonTrail>().Celestials();
                buttondestroy.GetComponent<ButtonDestroy>().Celestials();
                newplanet.SetActive(true);
                /*if(SaveManager.Instance != null)
                {
                    SaveManager.Instance.AddObj(newplanet, ButtonType.type);
                }*/
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
                    Time.timeScale = 10.0f;
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
                Error.SetActive(false);
                ErrorName.SetActive(false);
                ErrorField.SetActive(false);
            }
            catch
            {
                Error.SetActive(true);
                ErrorName.SetActive(false);
                ErrorField.SetActive(true);
            }
        }
        else
        {
            Error.SetActive(true);
            ErrorName.SetActive(true);
            ErrorField.SetActive(false);
        }
    }
}
