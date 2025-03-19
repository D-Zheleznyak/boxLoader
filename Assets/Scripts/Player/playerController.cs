using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;
    public float otherSpeed;
    public float runSpeed;

    public Animator animator;

    public Joystick joy;

    public Vector3 jump;
    public float jumpForce;
    public bool isJumping;
    Rigidbody rb;

    public string myBoxColor;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void Update()
    {
        Vector3 movement = new Vector3(joy.Horizontal, 0.0f, joy.Vertical);
        transform.Translate(movement * speed * Time.deltaTime);

        OnJump();

        if ((joy.Horizontal > 0 || joy.Vertical > 0 && speed > 0 && isJumping == false))
        {
            animator.SetBool("running", true);

            if ((Input.GetKey(KeyCode.LeftShift)))
            {
                //animator.SetTrigger("running");
            }
        }
        else
        {
            animator.SetBool("running", false);
            //animator.speed = 0;
        }
    }

    private void OnJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            //rb.linearVelocity = new Vector3(0, jumpForce, 0);
            isJumping = true;

            animator.speed = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isJumping = false;
    }
}

