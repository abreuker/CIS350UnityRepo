using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Anna Breuker
 * Challenge2
 * This script makes whatever it's attached to move forward.
 */
public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
