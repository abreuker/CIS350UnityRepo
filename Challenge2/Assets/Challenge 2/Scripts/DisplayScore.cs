using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * Anna Breuker
 * Challenge2
 * This script is responsible for displaying the score.
 */
public class DisplayScore : MonoBehaviour
{
    public Text textbox;

    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        //set text ref on start
        textbox = GetComponent<Text>();

        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;
    }
}
