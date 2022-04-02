using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * Anna Breuker
 * Assignment 6
 * A script that manages the score.
 */

//attach to empty game object
public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static float score;

    public Text textbox;

    public TutorialManager tutManager;

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //game not over??? display score
        if (!gameOver && tutManager.progression >= 5)
        {
            textbox.text = "Score: " + score;
        }

        //win condition: 75 or more points
        if (score >= 75 || won)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You Win :)\nPress R to try again!";
            }
            else
            {
                textbox.text = "You lose :(\nPress R to try again!";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}