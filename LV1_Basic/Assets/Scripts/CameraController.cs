using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;    
    }
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
    // Update is called once per frame
    void Update()
    {
    }
}
