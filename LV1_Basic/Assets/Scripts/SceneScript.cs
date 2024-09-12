using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Invoke("MoveToSceneTwo", 3.0f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    private void MoveToSceneTwo()
    {
        SceneManager.LoadScene("Scenes/SceneTwo");
    }
}
