using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Anna Breuker
 * Prototype 1
 * A script that has the camera following the player.
 */

public class CamFollowPlayer : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -15);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
