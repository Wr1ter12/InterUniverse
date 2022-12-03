using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCreate : MonoBehaviour
{
    public GameObject planet;
    [SerializeField] private Behaviour script;
    public GameObject input;
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
        Time.timeScale = 0f;
        script.enabled = false;
        input.SetActive(true);
    }
}
