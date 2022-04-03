using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
/*
 * Anna Breuker
 * Assignment 6
 * A class responsible for the tutorial.
 */
public class TutorialManager : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Text tutorialText;
    public int progression = 0;
    public GameObject orb;
    public GameObject cube;

    public bool isActuallyTutorial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActuallyTutorial)
        {
            tutorialText = scoreManager.textbox;
            if (progression < 5)
            {
                //Time.timeScale = 0f;
                if (progression == 0)
                {
                    tutorialText.text = "Welcome to Roly-Poly! \nA game where you control this little blue ball!"
                                        + "\nPress [Space] to continue";
                    progression++;

                }
                else if (Input.GetKeyDown(KeyCode.Space) && progression == 1)
                {
                    tutorialText.text = "To control the ball, use [A] and [D] or [<-] and [->]"
                                        + "\nPress [Space] to continue";
                    progression++;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && progression == 2)
                {
                    tutorialText.text = "To win, collect enough orbs to get a score of 75!"
                                        + "\nPress [Space] to continue";
                    Instantiate(orb, new Vector3(0, .5f, 20), orb.transform.rotation);
                    progression++;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && progression == 3)
                {
                    tutorialText.text = "Try to avoid these red cubes and don't fall off the edge or else you'll lose!"
                                        + "\nPress [Space] to continue";
                    Instantiate(cube, new Vector3(-2.75f, 0.9864014f, 20), cube.transform.rotation);
                    progression++;
                }
                else if (Input.GetKeyDown(KeyCode.Space) && progression == 4)
                {
                    tutorialText.text = "Have fun!"
                                        + "\nPress [Space] to start";
                    progression++;
                }
            }
            else
            {
                ScoreManager.won = true;
            }
        }
    }
}
