using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonInput : MonoBehaviour
{
    public GameObject input;
    [SerializeField] private TMP_InputField m_inputField_s;
    [SerializeField] private TMP_InputField m_inputField_m;
    [SerializeField] private TMP_InputField m_inputField_ax;
    [SerializeField] private Behaviour script;
    float scales;
    float masses;
    public GameObject planet;
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
        float scales = float.Parse(m_inputField_s.text);
        float masses = float.Parse(m_inputField_m.text);
        float axes = float.Parse(m_inputField_ax.text);
        planet = OnClick.planet;
        planet.gameObject.transform.localScale = new Vector3(scales, scales, scales);
        planet.GetComponent<Rigidbody>().mass = masses;
        planet.GetComponent<SpeedController>().speed = axes;
        script.enabled = true;
        input.SetActive(false);
    }
}
