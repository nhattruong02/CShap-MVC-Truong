using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    Animator anim;
    float speed = 0.1f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A)
            || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)) {
            anim.SetBool("Walk",true);
            anim.SetBool("Stop", false);
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A)
            || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("Stop",true);
            anim.SetBool("Walk", false);
        }

    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0, 0.5f), ForceMode.VelocityChange);
            /*   transform.position += Vector3.forward * Time.deltaTime * speed;*/
            rb.rotation = Quaternion.LookRotation(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, -0.5f), ForceMode.VelocityChange);
            rb.rotation = Quaternion.LookRotation(Vector3.back);
            /*transform.position -= Vector3.forward * Time.deltaTime * speed;*/
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-0.5f, 0, 0), ForceMode.VelocityChange);
            rb.rotation = Quaternion.LookRotation(Vector3.left);
            /*            transform.position += Vector3.left * Time.deltaTime * speed;
            */
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(0.5f, 0, 0), ForceMode.VelocityChange);
            rb.rotation = Quaternion.LookRotation(Vector3.right);
            /*            transform.position -= Vector3.left * Time.deltaTime * speed;
            */
        }
    }
}
