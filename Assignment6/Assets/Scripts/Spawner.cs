using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] orbPrefabs;
    public GameObject[] obstaclePrefabs;
    public int[] xPos;
    public int[] xPosObst;
    //private Vector3 spawnPosition = new Vector3(25, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;

    //private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        //playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        InvokeRepeating("SpawnOrbs", 3, 3);
    }

    //spawns in box obstacles
    void SpawnObstacle()
    {
        if (ScoreManager.gameOver == false)
        {
            int rand1 = Random.Range(0, obstaclePrefabs.Length);//pick obstacle
            
            int rand2 = Random.Range(0, xPosObst.Length); //pick location
            int rand2point5 = Random.Range(0, xPosObst.Length); //second location?

            Instantiate(obstaclePrefabs[rand1], new Vector3(xPosObst[rand2], 0.9864014f, 20), obstaclePrefabs[rand1].transform.rotation);//spawn
            if (rand1 != rand2point5)//check if possible to spawn 2
            {
                Instantiate(obstaclePrefabs[rand1], new Vector3(xPosObst[rand2point5], 0.9864014f, 20), obstaclePrefabs[rand1].transform.rotation);
            }
        }
    }

    //spawns in collectable orbs
    void SpawnOrbs()
    {
        if (ScoreManager.gameOver == false)
        {
            int rand1 = Random.Range(0, orbPrefabs.Length);
            int rand2 = Random.Range(0, xPos.Length);
            Instantiate(orbPrefabs[rand1], new Vector3(xPos[rand2], .5f, 20), orbPrefabs[rand1].transform.rotation);
        }
    }
}
