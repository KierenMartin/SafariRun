using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(ScoreTracker))]


public class UnlockAnimalFacts : MonoBehaviour
{

    private float score;
    private ScoreTracker scoreTracker;
    int scoreInt;
    public Text FactOne;

    // Use this for initialization
    void Start()
    {
        scoreTracker = GetComponent<ScoreTracker>(); 
    }


    // Checks score on game screen
    void Update()
    {
        if (scoreTracker.Score > 30)
        {
            FactOne.text = "Fact 3 Unlocked";
        } 
        else if (scoreTracker.Score > 20)
        {
            FactOne.text = "Fact 2 Unlocked";
        }
        else if (scoreTracker.Score > 10)
        {
            FactOne.text = "Fact 1 Unlocked";
        }
    }


    // Updates score on game screen
    /*public float Score
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
        }
    }


    private void DrawFacts()
    {
        if (ScoreInt == 10)
        {
            FactOne.text = "Animal Fact Unlocked";  
        }
    }*/
}
 