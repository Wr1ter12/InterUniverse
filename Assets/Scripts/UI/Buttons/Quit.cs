using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    [SerializeField] Animator anim;
    
    public void onClick()
    {
        StartCoroutine(Exit());
    }

    IEnumerator Exit()
    {
        Time.timeScale = 1f;
        anim.SetTrigger("fadeIn");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Menu");
    }
}
