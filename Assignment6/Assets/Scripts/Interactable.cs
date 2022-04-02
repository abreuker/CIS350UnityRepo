using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
