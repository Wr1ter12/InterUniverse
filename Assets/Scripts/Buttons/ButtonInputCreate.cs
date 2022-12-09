using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonInputCreate : MonoBehaviour
{
    public GravitySystem gravitsys;
    public GameObject input;
    [SerializeField] private TMP_InputField m_inputField_name;
    [SerializeField] private TMP_InputField m_inputField_s;
    [SerializeField] private TMP_InputField m_inputField_m;
    [SerializeField] private TMP_InputField m_inputField_ax;
    [SerializeField] private TMP_InputField m_inputField_pos;
    [SerializeField] private Behaviour script;
    public GameObject planet;
    public GameObject sun;
    public static string name;
    // Start is called before the first frame update
    void Start()
    {
        
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
        float axes = float.Parse(m_inputField_ax.text);
        float pos = float.Parse(m_inputField_pos.text) * 15100;
        float sunpos = sun.transform.position.x;
        GameObject newplanet = Instantiate(planet, new Vector3(sunpos, 0, pos), Quaternion.Euler(0f, 0f, 0f));
        newplanet.name = planetname;
        newplanet.gameObject.transform.localScale = new Vector3(scales, scales, scales);
        newplanet.GetComponent<Rigidbody>().mass = masses;
        newplanet.GetComponent<SpeedController>().speed = axes;
        name = newplanet.name;
        gravitsys.GetComponent<GravitySystem>().Celestials();
        newplanet.SetActive(true);
        script.enabled = true;
        input.SetActive(false);
    }
}
