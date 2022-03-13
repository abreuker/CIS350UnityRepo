using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Anna Breuker
* Assignment 5B
* This script is reposnible for the player movement.
*/

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;
    //vars for gravity
    public Vector3 velocity;
    public float gravity = -9.81f;
    public float gravityMultiplier = 2f;
    //vars for checking ground
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public bool isGrounded;

    public float jumpHeight = 3f;

    private UIManager uIManager;

    public void Awake()
    {
        gravity *= gravityMultiplier;
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    void Update()
    {
        //is player on ground?
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2;
        }

        //get input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        //jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //gravity to velocity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WinZone"))
        {
            uIManager.won = true;
        }
    }
}
