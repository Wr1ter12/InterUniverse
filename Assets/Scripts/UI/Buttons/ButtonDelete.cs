using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDelete : MonoBehaviour
{
    public GameObject input;
    [SerializeField] private Behaviour script;
    public GameObject a;
    public GravitySystem gravitsys;
    public ButtonTrail buttontrail;
    [SerializeField] GameObject temparray;

    public void onClick()
    {
        a = OnClick.planet;
        if(a.name == "Mercury" || a.name == "Sun")
        {
            gravitsys.celestials.Remove(a);
            buttontrail.celestials.Remove(a);
            try
            {
                temparray.GetComponent<TempArray>().stars.Remove(a);
            }
            catch{}
            if(SaveManager.Instance != null)
            {
                SaveManager.Instance.RemoveObj(a.name);
            }
            a.SetActive(false);
        }
        else
        {
            gravitsys.celestials.Remove(a);
            buttontrail.celestials.Remove(a);
            try
            {
                temparray.GetComponent<TempArray>().stars.Remove(a);
            }
            catch{}
            if(SaveManager.Instance != null)
            {
                SaveManager.Instance.RemoveObj(a.name);
            }
            Destroy(a);
        }
        script.enabled = true;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        input.SetActive(false);
    }
}
