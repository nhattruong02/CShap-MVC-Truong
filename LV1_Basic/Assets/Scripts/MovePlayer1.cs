using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer1 : MonoBehaviour
{
    [SerializeField] float speed = 6.0f;
    [SerializeField] float jumpSpeed = 8.0f;
    [SerializeField] float gravity = 20.0f;
    [SerializeField] float rotateSpeed = 3.0f;
    private Vector3 moveDir = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if(controller.isGrounded)
        {
            moveDir = new Vector3(0, 0, Input.GetAxisRaw("Vertical"));
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= speed;
            if (Input.GetButton("Jump"))
                moveDir.y = jumpSpeed;
        }
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
    }
}
