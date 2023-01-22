using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCancel : MonoBehaviour
{
    public GameObject input;
    [SerializeField] private Behaviour script;
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
        Time.timeScale = 1f;
        script.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        input.SetActive(false);
    }
}
