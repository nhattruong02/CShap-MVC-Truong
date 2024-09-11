using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Cube").transform.localScale = new Vector3(2,3,4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
