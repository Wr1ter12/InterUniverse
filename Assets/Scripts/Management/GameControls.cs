using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControls : MonoBehaviour
{
   void Update()
   {
      if (Input.GetKey("escape"))
      {
         Application.Quit();
      }
      if(Input.GetKey(KeyCode.LeftAlt))
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
