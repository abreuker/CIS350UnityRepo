using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public List<GameObject> targets;
    private float spawnRate = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            //wait 1 sec
            yield return new WaitForSeconds(spawnRate);
            //pick random index  num
            int index = Random.Range(0, targets.Count);
            //spawn prefab @ random index
            Instantiate(targets[index]);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
