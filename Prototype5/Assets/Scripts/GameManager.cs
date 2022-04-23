﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/*
 * Anna Breuker
 * Prototype 5
 * Code for the game manager, which manages the different states of the game and the score.
 */
public class GameManager : MonoBehaviour
{

    public List<GameObject> targets;
    private float spawnRate = 1.0f;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    private int score;

    public bool isGameActive;

    public Button restartButton;

    public GameObject titleScreen;

    public void StartGame(int difficulty)
    {
        spawnRate /= difficulty;
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            //wait 1 sec
            yield return new WaitForSeconds(spawnRate);
            //pick random index  num
            int index = Random.Range(0, targets.Count);
            //spawn prefab @ random index
            Instantiate(targets[index]);

            //testing updateScore by adding 5 every spawn
            //UpdateScore(5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
