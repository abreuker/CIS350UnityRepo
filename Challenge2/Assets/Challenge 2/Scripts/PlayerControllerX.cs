using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Anna Breuker
 * Challenge2
 * This script allows the player to send out dogs.
 */
public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float delay;
    public bool canSendDog = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSendDog)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSendDog = false;
            Invoke("DelayDog", delay);
        }
    }

    void DelayDog()
    {
        canSendDog = true;
    }
}
