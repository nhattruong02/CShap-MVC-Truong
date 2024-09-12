using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTwoScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("What's my name:" + PlayerPrefs.GetString("Name"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
