using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Anna Breuker
 * Assignment 6
 * An abstract class that manages an Enemy that implements the IDamagable interface.
 */

public abstract class Enemy : MonoBehaviour, IDamagable
{

    protected float speed;
    protected float health;

    [SerializeField] protected Weapon weapon;

    protected virtual void Awake()
    {
        weapon = gameObject.AddComponent<Weapon>();
        speed = 5f;
        health = 100;

        weapon.damageBonus = 10;
    }

    protected abstract void Attack(int amount);

    public abstract void TakeDamage(int amount);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
