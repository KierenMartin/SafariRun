using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreTable : MonoBehaviour
{
    public bool gameOver;
    public string HighScore;
    public int score;
    public int temp;


	void Start ()
    {
        score = 0;
	}
	
	
	void OnGameOver ()
    {
        gameOver = true;
        //score > 0;
        // top 5 high scores
        for (int i = 1; i <= 5; i++)
        {
            // if current score is in top 5
            if (PlayerPrefs.GetInt("HighScore" + i) < score)
            {
                // store the old high score in a temp variable to shift it down
                temp = PlayerPrefs.GetInt("HighScore" + i);

                // store the current high score to HighScore
                PlayerPrefs.SetInt("HighScore" + i, score);

                //do this for shifting scores down
                if (i < 5)
                {
                    int j = i + 1;
                    score = PlayerPrefs.GetInt("HighScore" + j);
                    PlayerPrefs.SetInt("HighScore" + j, temp);
                }
            }
        }
	}

    void OnGUI()
    {
        if (gameOver)
        {
            for (int i = 1; i <= 5; i++)
            {
                GUI.Box(new Rect(100, 75 * i, 150, 50), 
                    "Pos " + i + ". " + PlayerPrefs.GetInt("HighScore" + i));
            }
        }
    }
}
