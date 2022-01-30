using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Anna Breuker
 * Prototype 1
 * An unused script that shows when player enters
 * a trigger zone.
 */

//attach to player
public class PlayerEnterTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
