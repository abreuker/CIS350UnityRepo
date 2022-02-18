using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Anna Breuker
 * Prototype3
 * This script adds to the score when the player passes an obstacle.
 */

public class AddScore : MonoBehaviour
{
    private UIManager uIManager;

    private bool triggered;
    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }   
}
