using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OnClick : MonoBehaviour
{
    public GameObject input;
    [SerializeField] private Behaviour script;
    public static GameObject planet;
    GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera");
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
        camera.GetComponent<AudioSource>().Play();
        input.SetActive(true);
    }
}
