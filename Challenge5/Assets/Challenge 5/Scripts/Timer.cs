using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
/*
 * Anna Breuker
 * Challenge 5
 * This script manages the timer. - Code adapted from https://youtu.be/HmHPJL-OcQE tutorial.
 */
public class Timer : MonoBehaviour
{
    public float timeValue = 60;
    public TextMeshProUGUI timeText;
    private GameManagerX gameManagerX;

    void Start()
    {
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerX.isGameActive)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            else
            {
                timeValue = 0;
                gameManagerX.GameOver();
            }
            DisplayTime(timeValue);
        }

    }
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        //code to turn time into minutes & seconds, which after looking at the requirements... isn't needed.
        //float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        //float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        //display time left
        timeText.text = "Time: " + Mathf.FloorToInt(timeToDisplay);

    }
}
