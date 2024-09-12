using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("Name","Truong");
        Debug.Log("DataSaved");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
