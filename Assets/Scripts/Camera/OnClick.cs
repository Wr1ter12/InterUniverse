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
        create = store.GetComponent<InactiveManager>().creating;
        tutor = store.GetComponent<InactiveManager>().tutor;
        quit = store.GetComponent<InactiveManager>().quit;
        input = store.GetComponent<InactiveManager>().changing;
    }

    void Update(){
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            { 
                if(hit.collider == gameObject.GetComponent<Collider>())
                {
                    if(tutor.activeSelf == false && create.activeSelf == false && quit.activeSelf == false)
                    {
                        planet = gameObject;
                        if(planet.GetComponent<Outline>().enabled == false)
                        {
                            planet.GetComponent<Outline>().enabled = true;
                        }
                        Time.timeScale = 0f;
                        Cursor.lockState = CursorLockMode.Confined;
                        script.enabled = false;
                        camera.GetComponent<AudioSource>().Play();
                        input.SetActive(true);
                    }
                }
            }
        }
    }

    void OnMouseDown()
    {
        if(tutor.activeSelf == false && create.activeSelf == false && quit.activeSelf == false)
        {
            planet = gameObject;
            if(planet.GetComponent<Outline>().enabled == false)
            {
                planet.GetComponent<Outline>().enabled = true;
            }
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.Confined;
            script.enabled = false;
            camera.GetComponent<AudioSource>().Play();
            input.SetActive(true);
        }
    }
}
