using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Anna Breuker
 * Prototype 1
 * A script that allows the user to control
 * the player.
 */

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    public float forwardInput;
    public float horizontalInput;
    

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //move forward with forward input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
