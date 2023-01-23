using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OnClick : MonoBehaviour
{
    GameObject input;
    [SerializeField] private Behaviour script;
    public static GameObject planet;
    GameObject camera;
    public GameObject store;

    public GameObject create;
    public GameObject tutor;
    public GameObject quit;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera");
        store = GameObject.Find("Storage");
        input = store.GetComponent<InactiveManager>().changing;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if(tutor.activeSelf == false && create.activeSelf == false && quit.activeSelf == false)
        {
            planet = gameObject;
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.Confined;
            script.enabled = false;
            camera.GetComponent<AudioSource>().Play();
            input.SetActive(true);
        }
    }
}
