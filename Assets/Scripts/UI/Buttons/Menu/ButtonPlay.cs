using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] string scene;

    public void onClick()
    {
        StartCoroutine(Play());
    }

    IEnumerator Play()
    {
        anim.SetTrigger("fadeIn");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(scene);
    }
}
