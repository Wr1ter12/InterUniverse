using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OnClick : MonoBehaviour
{
    public GameObject input;
    [SerializeField] private Behaviour script;
    public static GameObject planet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        planet = gameObject;
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.Confined;
        script.enabled = false;
        input.SetActive(true);
    }
}
