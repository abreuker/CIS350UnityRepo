using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
 * Anna Breuker
 * Prototype4
 * This script is responsible for displaying the wave number and if you've won.
 */
public class UIManager : MonoBehaviour
{
    public Text waveText;

    public SpawnManager spawnManager;
    public GameObject player;

    private bool won = false;
    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!won)
        {
            waveText.text = "Current Wave: " + spawnManager.waveNumber;
        }
        if (player.transform.position.y < -10)
        {
            won = true;
            waveText.text = "You Lose! \nPress R to retry!";
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if (spawnManager.waveNumber >= 10)
        {
            won = true;
            waveText.text = "You Win! \nPress R to retry!";
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
