using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private int screenWidth;
    private int screenHeight;

    public GameObject cam_holder; // пустышка камеры
    public float mouse_sens = 1f;
    public float wheel_sens = 1f;

    public float speed;
    public bool useCameraMovement;

    // Start is called before the first frame update
    void Start()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camPos = transform.position;

        /*if(Input.mousePosition.x <= 20)
        {
            camPos.z -= Time.deltaTime * speed;
        }
        else if (Input.mousePosition.x >= screenWidth - 20)
        {
            camPos.z += Time.deltaTime * speed;
        }
        else if (Input.mousePosition.y <= 20)
        {
            camPos.x += Time.deltaTime * speed;
        }
        else if (Input.mousePosition.y >= screenHeight - 20)
        {
            camPos.x -= Time.deltaTime * speed;
        }*/

        if(Input.GetKey(KeyCode.A))
        {
            camPos.z -= Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            camPos.z += Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            camPos.x += Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            camPos.x -= Time.deltaTime * speed;
        }

        float x_axis = Input.GetAxis("Mouse X") * mouse_sens;
        float y_axis = Input.GetAxis("Mouse Y") * mouse_sens;
        float z_axis = Input.GetAxis("Mouse ScrollWheel") * wheel_sens;
        cam_holder.transform.Rotate(Vector3.up, x_axis, Space.World);
        cam_holder.transform.Rotate(Vector3.left, y_axis, Space.Self);
        Camera.main.transform.localPosition = Camera.main.transform.localPosition * (1 - z_axis);



        transform.position = camPos;
    }
}
