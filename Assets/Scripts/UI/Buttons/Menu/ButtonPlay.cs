using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    [SerializeField] string scene;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick()
    {
        SceneManager.LoadScene(scene);
    }
}
