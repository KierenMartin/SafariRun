﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AnimalController))]
public class ScoreTracker : MonoBehaviour {

    private float score;
    public static ScoreTracker Instance;
    public Text ScoreText;
    private AnimalController animalController;
    
    //the array of values in the high score table
    int[] highScoreValues;
    //number of high scores in table
    int highScoreCount = 5;

    // Use this for initialization
    void Start()
    {
        animalController = GetComponent<AnimalController>();

        // loads high scores into PlayerPrefs
        highScoreValues = new int[highScoreCount];
        for (int x = 0; x < highScoreCount; x++)
        {
            highScoreValues[x] = PlayerPrefs.GetInt("highScoreValues" + x);
        }
    }


    // Checks score on game screen
    void Update()
    {
        if (!animalController.AnimalRunning)
        {
            return;
        }

        Score += Time.deltaTime;
    }   

    // Updates score on game screen
    public float Score
    {
        get
        {
            return score;
        }

        set
        {
            // assign to a variable
            score = value;
            //change score from float to int
            int ScoreInt = Mathf.FloorToInt(score);
            // update ScoreText in scene
            ScoreText.text = Mathf.FloorToInt(score).ToString();
        }
    }

    
    //top 5 high scores are saved in PlayerPrefs
    void SaveScores()
    {
        for (int x = 0; x < highScoreCount; x++)
        {
            PlayerPrefs.SetInt("highScoreValues" + x, highScoreValues[x]);
        }
    }


    //check the current score against the scores in the high score table
    public void CheckForHighScore(int value)
    {
        for (int x = 0; x < highScoreCount; x++)
        {
            if (value > highScoreValues[x])
            {
                for (int y = highScoreCount - 1; y > x; y--)
                {
                    highScoreValues[y] = highScoreValues[y - 1];
                }

                highScoreValues[x] = value;

                SaveScores();

                break;
            }
        }
    }


    private void Awake()
    {
        Instance = this;

        // sets score and HighScore to 0 at beginning of game
        // HighScore will be set to PlayerPrefs value each game
        ScoreText.text = "0";
<<<<<<< HEAD
        //HighScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
=======
    }
>>>>>>> Finella2


    public void EndGame()
    {
        CheckForHighScore(Mathf.FloorToInt(score));
        SceneManager.LoadScene("Start Screen");
    }

   
}
