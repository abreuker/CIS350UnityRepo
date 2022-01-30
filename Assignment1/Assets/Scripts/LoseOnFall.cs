using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Anna Breuker
 * Prototype 1
 * A script that sets gameOver to true when
 * the player dies.
 */

//attach to player
public class LoseOnFall : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
