using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Anna Breuker
 * Prototype4
 * This script is responsible for enemy ai.
 */
public class EnemyAI : MonoBehaviour
{

    public Rigidbody enemyRb;
    public GameObject player;
    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
