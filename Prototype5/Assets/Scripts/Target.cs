using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;

    private float minSpeed = 12;
    private float maxSpeed = 16;

    private float maxTorque = 10;

    private float xRange = 4;
    private float ySpawnPos = -6;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        //add upwards force mult by a randomized speed
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);

        //add a torque  (rotational force) with randomized xyz values
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        //set pos with randomized x value
        transform.position = new Vector3(RandomSpawnPosition());
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    private float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    private Vector3 RandomSpawnPosition()
    { 
        return Random.Range(-xRange, xRange), ySpawnPos;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
