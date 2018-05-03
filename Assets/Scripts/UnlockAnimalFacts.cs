using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AnimalController))]


public class UnlockAnimalFacts : MonoBehaviour
{

    private float score;
    public Text ScoreText;
    private AnimalController animalController;
    int ScoreInt;
    public Text FactOne;

    // Use this for initialization
    void Start()
    {
        animalController = GetComponent<AnimalController>(); 
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
        }
    }


    private void DrawFacts()
    {
        if (ScoreInt == 10)
        {
            FactOne.text = "Hello";  
        }
    }
}
 