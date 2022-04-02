using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : Interactable
{
    protected override void Awake()
    {
        base.Awake();
        speed = 15;
        isObstacle = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.gameOver = true;
        }
    }
}
