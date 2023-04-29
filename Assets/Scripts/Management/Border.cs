using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] int border;

    void Update()
    {
        if(Camera.main.transform.position.x > border || Camera.main.transform.position.y > border || Camera.main.transform.position.z > border || Camera.main.transform.position.x < -border || Camera.main.transform.position.y < -border || Camera.main.transform.position.z < -border)
        {
            anim.SetTrigger("fade");
            Camera.main.transform.position = new Vector3(5200, 3000, 8000);
        }
    }
}
