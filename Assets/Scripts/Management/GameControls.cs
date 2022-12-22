using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControls : MonoBehaviour
{
   [SerializeField] private Behaviour script;
   public GameObject Quit;

   void Update()
   {
      if (Input.GetKey("escape"))
      {
         Time.timeScale = 0f;
         script.enabled = false;
         Cursor.lockState = CursorLockMode.Confined;
         Quit.SetActive(true);
      }
      if(Input.GetKeyDown(KeyCode.LeftAlt))
      {
         if(Cursor.lockState == CursorLockMode.Locked)
         {
            Cursor.lockState = CursorLockMode.Confined;
         }
         else
         {
            Cursor.lockState = CursorLockMode.Locked;
         }
      }
   }
}
