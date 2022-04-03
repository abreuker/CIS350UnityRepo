using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Anna Breuker
 * Assignment 6
 * An abstract class that manages all kinds of interactable objects (obstacles and collectable orbs)
 */
public abstract class Interactable : MonoBehaviour
{
    public float speed;
    public bool isObstacle;
    public bool triggered;

    protected virtual void Awake()
    {
        speed = 10;
        triggered = false;
    }
    

}
