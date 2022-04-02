using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shade : Enemy
{

    protected int damage;

    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();
        health = 120;
        damage = 20;
        GameManager.Instance.score = 5; 
    }

     protected override void Attack(int amount) 
    {
        Debug.Log("Shade Attacks");
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("Shade took " + amount + " points of damage!");
        health -= amount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
