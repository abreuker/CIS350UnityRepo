using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbBehavior : Interactable, IWorthPoints
{
    public float pointValue;
    
    public void GivePoints(float amount)
    {
        ScoreManager.score += amount;
    }

    protected override void Awake()
    {
        base.Awake();
        isObstacle = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            GivePoints(pointValue);
            Destroy(gameObject);
        }
    }
}
