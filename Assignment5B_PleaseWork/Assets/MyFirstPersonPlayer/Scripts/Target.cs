using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Anna Breuker
* Assignment 5B
* This script is reposnible for anything hit with the gun taking damage and dying.
*/

public class Target : MonoBehaviour
{
    public float health = 50f;


    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
