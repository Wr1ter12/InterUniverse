using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseText : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        transform.position = new Vector3(mousePos.x + 50, mousePos.y, 0f);
    }
}
