using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    Rigidbody playerRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*movePosition();*/
        movePhysics();
       
    }

    private void movePhysics()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRigidbody.AddForce(new Vector3 (0, 0, 1),ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidbody.AddForce(new Vector3(0, 0, -1), ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody.AddForce(new Vector3(-1, 0, 0), ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody.AddForce(new Vector3(1, 0, 0), ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            playerRigidbody.AddForce(new Vector3(0, 1, 0), ForceMode.VelocityChange);
        }
    }

    private void movePosition()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 playerPosition = transform.position;
            playerPosition.z += 0.1f;
            transform.position = playerPosition;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 playerPosition = transform.position;
            playerPosition.z -= 0.1f;
            transform.position = playerPosition;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 playerPosition = transform.position;
            playerPosition.x -= 0.1f;
            transform.position = playerPosition;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 playerPosition = transform.position;
            playerPosition.x += 0.1f;
            transform.position = playerPosition;
        }
    }
}
