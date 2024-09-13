using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void rotateCameraWithMouse()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
    private void moveCameraWithMouse()
    {
        if(Input.GetAxis("Mouse X") > 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 
                0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
        }else if(Input.GetAxis("Mouse X") < 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
        }
    }
    // Update is called once per frame
    void Update()
    {
        moveCameraWithMouse();
/*        rotateCameraWithMouse();
*/    }
}
