using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Anna Breuker
 * Assignment 5A
 * This script allows the win trigger zone to show that the game is won.
 */

public class WinZoneBehavior : MonoBehaviour
{
    public PlayerPlatformerController playerControllerScript;

    public BoxCollider2D winCollider2D;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("player won!");
            playerControllerScript.won = true;
        }
    }
}
