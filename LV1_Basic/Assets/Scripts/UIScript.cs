using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Canvas/Text").GetComponent<Text>().text = "Zombie";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buttonTest(Button btn)
    {
        Debug.Log(btn.name);
        Application.OpenURL("www.google.com");
    }
}
