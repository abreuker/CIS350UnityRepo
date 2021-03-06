using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Anna Breuker
 * Assignment 6
 * A class that makes sure that all interactables move towards the screen, what I consider "back."
 */
public class MoveBack : MonoBehaviour
{
    //public float speed = 40;
    private float backBound = -15;
    public Interactable thisInteractable;

   // private PlayerController playerControllerScript;

    void Start()
    {
        //playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (ScoreManager.gameOver == false)
        {
            transform.Translate(Vector3.back * Time.deltaTime * thisInteractable.speed);
        }

        if (transform.position.z < backBound)
        {
            Destroy(gameObject);
        }
    }
}
