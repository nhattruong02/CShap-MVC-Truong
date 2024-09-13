using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    public PlanetScript PlanetScript;
    private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        playerTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlanetScript)
        {
            PlanetScript.Attract(playerTransform);
        }
    }
}
