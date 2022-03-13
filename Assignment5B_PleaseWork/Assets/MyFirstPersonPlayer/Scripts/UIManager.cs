using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * Anna Breuker
 * Assignment5B
 * This script manages the UI and how the score is displayed to the user.
 */

public class UIManager : MonoBehaviour
{

    public Text scoreText;
    public int score = 0;

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!won)
        {
            scoreText.text = "Score: " + score;
        }
        if (won)
        {
            scoreText.text = "You win!\nYour score is: " + score + "\nPress R to restart!";
        }



        if (won && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}

