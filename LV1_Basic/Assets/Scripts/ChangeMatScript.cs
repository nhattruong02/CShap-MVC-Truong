using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMatScript : MonoBehaviour
{
    public Material matRed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material = matRed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
