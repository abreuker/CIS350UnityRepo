using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * Anna Breuker
 * Prototype3
 * This script manages the UI and how it's displayed to the user.
 */

public class UIManager : MonoBehaviour
{

    public Text scoreText;
    public int score = 0;

    public PlayerController playerControllerScript;

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }
        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        //loss condition
        if (playerControllerScript.gameOver && !won)
        { 
            scoreText.text = "You Lose :(\nPress R to Try Again!";
        }
        if (score >= 10)
        {
            playerControllerScript.gameOver = true;
            won = true;
            //stop running
            scoreText.text = "You win :)\nPress R to Try Again!";
        }
        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
