using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Anna Breuker
 * Prototype 1
 * A script that incriments the score by one
 * for each trigger zone (and sets each zone to
 * triggered.)
 */

//attach to triggerZone
public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
