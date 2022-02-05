using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Anna Breuker
 * Prototype2
 * This script destroys both animals and food when they go out
 * of bounds.
 */

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    // Update is called once per frame
    void Update()
    {
        //food out of bounds
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //animal out of bounds
        if (transform.position.z < bottomBound)
        {
            //Debug.Log("Game Over!");

            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();

            Destroy(gameObject);
        }
    }
}
