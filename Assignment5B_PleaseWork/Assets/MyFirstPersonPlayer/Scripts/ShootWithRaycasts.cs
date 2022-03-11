using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Anna Breuker
* Assignment 5B
* This script is reposnible for the gun shooting properly.
*/

public class ShootWithRaycasts : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public Camera cam;

    public ParticleSystem muzzleFlash;

    public float hitForce = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hitInfo;
        //if we hit something........
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        { 
            Debug.Log(hitInfo.transform.gameObject.name);

            //get target script off hit object
            Target target = hitInfo.transform.gameObject.GetComponent<Target>();
            //if it's found? damage time.
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            if (hitInfo.rigidbody != null)
            {
                hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
            }
        }
    }
}
