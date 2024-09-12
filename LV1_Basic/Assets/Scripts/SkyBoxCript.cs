using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxCript : MonoBehaviour
{
    public Material skyOne;
    public Material skyTwo;
    public Material skyThree;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = skyOne;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
