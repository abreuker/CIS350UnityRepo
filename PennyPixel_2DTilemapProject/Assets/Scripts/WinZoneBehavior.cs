using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZoneBehavior : MonoBehaviour
{
    public PlayerPlatformerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerPlatformerController>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerControllerScript.won = true;
        }
    }
}
