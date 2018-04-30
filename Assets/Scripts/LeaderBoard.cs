using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoard : MonoBehaviour
{
    public Text[] highScores;
    int[] highScoreValues;

    //get the five updated high scores from PlayerPrefs
    void Start ()
    {
        highScoreValues = new int[highScores.Length];
        for (int x = 0; x < highScores.Length; x++)
        {
            highScoreValues [x] = PlayerPrefs.GetInt("highScoreValues" + x);
        }

        DrawScores();
	}


    // put top five updates scores into the Leaderboard
    void DrawScores()
    {
        for (int x = 0; x < highScores.Length; x++)
        {
            highScores[x].text = highScoreValues[x].ToString();
        }
    }
}
