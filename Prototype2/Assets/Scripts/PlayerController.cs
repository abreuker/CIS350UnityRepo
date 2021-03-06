using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Anna Breuker
 * Prototype2
 * This script is responsible for controlling the 
 * player.
 */

//attach to player
public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 14;

    // Update is called once per frame
    void Update()
    {
        //get hori input
        horizontalInput = Input.GetAxis("Horizontal");

        //transform horizontally with input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keep player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
