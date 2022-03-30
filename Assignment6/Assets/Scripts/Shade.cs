using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shade : Enemy
{

    protected int damage;

    // Start is called before the first frame update
    void override Awake()
    {
        base.Awake();
        health = 120;
        damage = 20;
    }

    protected override void Attack()
    {
        Debug.Log("Shade Attacks");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
