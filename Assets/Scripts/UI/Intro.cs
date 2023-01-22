using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IntroChanger());
    }

    IEnumerator IntroChanger()
    {
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene("Menu");
    }
}
