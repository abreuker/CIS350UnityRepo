using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Anna Breuker
 * Challenge2
 * This script destroys both dogs and balls when they go
 * out of bounds.
 */

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -40;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();
            Destroy(gameObject);
        }

    }
}
