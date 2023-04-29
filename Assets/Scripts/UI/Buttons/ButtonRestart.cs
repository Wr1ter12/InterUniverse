using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonRestart : MonoBehaviour
{
    [SerializeField] Animator anim;

    public void onClick()
    {
        StartCoroutine(Restart());
    }

    IEnumerator Restart()
    {
        Time.timeScale = 1f;
        anim.SetTrigger("fadeIn");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
