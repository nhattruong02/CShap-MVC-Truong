using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMove : MonoBehaviour
{
    GameObject playerObj;
    Vector3 cameraOffSet;
    // Start is called before the first frame update
    void Start()
    {
/*        playerObj = GameObject.Find("Car");
        cameraOffSet = new Vector3(0, 0.5f, -3f);*/
        playerObj = GameObject.Find("Zombie");
        cameraOffSet = new Vector3(0, 1f, -7f);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerObj.transform.position + cameraOffSet;
    }
}
