using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{

    protected float speed;
    protected float health;

    protected virtual void Awake()
    {
        spped = 5f;
        health = 100;
    }

    protected abstract void Attack();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
