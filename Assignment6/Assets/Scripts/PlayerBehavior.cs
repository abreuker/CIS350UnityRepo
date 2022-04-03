using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Anna Breuker
* Assignment 6
* This script is reposnible for the player movement.
*/

public class PlayerBehavior : MonoBehaviour
{
    public float speed = 40.0f;
    public Rigidbody rb;
    public Vector3 movement;
    public Vector3 rotate;
    public float adjustment;

    public void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    public void Awake()
    {
        //gravity *= gravityMultiplier;
       // uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0,0);
        if (transform.position.y < -10)
        {
            ScoreManager.gameOver = true;
        }
    }

    void FixedUpdate()
    {
        moveCharacter(movement);
        //rotateCharacter(rotate);
    }

    void moveCharacter(Vector3 direction)
    {
        rb.AddForce(direction * speed);
    }



}
