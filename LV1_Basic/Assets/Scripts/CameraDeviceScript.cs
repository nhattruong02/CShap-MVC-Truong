using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDeviceScript : MonoBehaviour
{
    static WebCamTexture cam;
    // Start is called before the first frame update
    void Start()
    {
        if(cam == null)
        {
            cam = new WebCamTexture();
        }
        GetComponent<Renderer>().material.mainTexture = cam;
        if(!cam.isPlaying)
        {
            cam.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
