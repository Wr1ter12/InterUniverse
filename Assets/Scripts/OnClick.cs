using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OnClick : MonoBehaviour
{
    GameObject input;
    [SerializeField] private Behaviour script;
    public static GameObject planet;
    GameObject cam;
    public GameObject store;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        store = GameObject.Find("Storage");
        input = store.GetComponent<InactiveManager>().changing;
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
        cam.GetComponent<AudioSource>().Play();
        input.SetActive(true);
    }
}
