using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Anna Breuker
 * Challenge 5
 * This script makes the particles destroy themselves after 2 seconds.
 */
public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }


}
