using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    public PlayerPlatformerController playerControllerScript;

    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }
        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerPlatformerController>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            scoreText.text = "Score: " + score;
        }
        if (playerControllerScript.fallen)
        {
            scoreText.text = "You lose! \nPress R to try again!";
            gameOver = true;
        }
        if (playerControllerScript.won)
        {
            scoreText.text = "You win! \nPress R to try again!";
            gameOver = true;
        }
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
