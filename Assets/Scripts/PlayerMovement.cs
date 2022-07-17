using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public float groundDrag;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    public Animator anim;

    bool run = false;
    bool left = false;
    bool right = false;
    bool back = false;
    bool interact = false;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    // Update is called once per frame
    private void Update()
    {
        checkKeys();

        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);

        MyInput();

        if (grounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = 0;
        }

        checkAnims();


    }

    private void checkAnims()
    {
        if (run)
        {
            anim.SetBool("RunForward", true);
        }
        else
        {
            anim.SetBool("RunForward", false);
        }

        if (right)
        {
            anim.SetBool("RunRight", true);
        }
        else
        {
            anim.SetBool("RunRight", false);
        }

        if (left)
        {
            anim.SetBool("RunLeft", true);
        }
        else
        {
            anim.SetBool("RunLeft", false);
        }

        if (back)
        {
            anim.SetBool("RunBack", true);
        }
        else
        {
            anim.SetBool("RunBack", false);
        }

        if (interact)
        {
            anim.SetBool("isInteracting", true);
        }
        else
        {
            anim.SetBool("isInteracting", false);
        }
    }

    private void checkKeys()
    {
        if (Input.GetKey(KeyCode.W))
        {
            run = true;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            run = false;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            right = true;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            right = false;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            back = true;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            back = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            left = true;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            left = false;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            interact = true;
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            interact = false;
        }
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }
}
