using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
 * Anna Breuker
 * Challenge4
 * This script is responsible for displaying the wave number and if you've won.
 */
public class UIManagerX : MonoBehaviour
{
    public Text waveText;

    public SpawnManagerX spawnManager;
    public EnemyX enemy;
    public GameObject player;

    public  bool won = false;

    public bool seenTutorial = false;
    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManagerX>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!seenTutorial)
        {
            waveText.text = "If you let all enemies into your goal, you lose!\nIf you make it past wave 10, you win!" +
                "\nPress space to continue.";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                seenTutorial = true;
            }
        }
        if (!won && seenTutorial)
        {
            waveText.text = "Current Wave: " + (spawnManager.waveCount-1);
        }
        if (spawnManager.enemiesThroughPlayerGoal >= spawnManager.waveCount-1 && spawnManager.waveCount != 1)
        {
            won = true;
            waveText.text = "You Lose! \nPress R to retry!";
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if (spawnManager.waveCount-1 > 10)
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
