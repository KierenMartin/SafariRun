using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour {

    public int score;
    public static ScoreTracker Instance;
    public Text ScoreText;
    public Text HighScoreText;

    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            // assign to a variable
            score = value;
            // update ScoreText in scene
            ScoreText.text = score.ToString();

            // checking whether current score is greater than value in PlayerPrefs
            if (PlayerPrefs.GetInt("HighScore") < score)
            {
                // update value in PlayerPrefs
                PlayerPrefs.SetInt("HighScore", score);
                // update HighScoreText in game
                HighScoreText.text = score.ToString();
            }
        }

    }


    private void Awake()
    {
        Instance = this;

        // if we haven't created a key in PlayerPrefs called HighScore, 
        // HighScore will be set to 0 
        if (!PlayerPrefs.HasKey("HighScore"))
            PlayerPrefs.SetInt("HighScore", 0);
        
        // sets score and HighScore to 0 at beginning of game
        // HighScore will be set to PlayerPrefs value each game
        ScoreText.text = "0";
        HighScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();


    }
}
