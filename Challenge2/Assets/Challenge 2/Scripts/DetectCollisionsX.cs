using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Anna Breuker
 * Challenge2
 * This script detects when collisions occur and 
 * incriments the score when a ball collides with
 * dog.
 */

public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScore displayScoreScript;

    void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dog")
        {
            displayScoreScript.score++;
        }
        Destroy(gameObject);
    }
}
