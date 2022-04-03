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
            if (won && tutManager.isActuallyTutorial)
            {
                textbox.text = "Have fun!\nPress M to return to the main menu!";
            }
            else if (won)
            {
                textbox.text = "You Win :)\nPress M to return to the main menu!";
            }
            else
            {
                textbox.text = "You lose :(\nPress M to return to the main menu and try again!";
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}