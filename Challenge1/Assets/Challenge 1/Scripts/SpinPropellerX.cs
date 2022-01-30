using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Anna Breuker
 * Challenge 1
 * A script that makes the propeller spin :)
 */

//attach to player
public class SpinPropellerX : MonoBehaviour
{

    public GameObject propeller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        propeller.transform.Rotate(Vector3.forward, 5);
    }
}
