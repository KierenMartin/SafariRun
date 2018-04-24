using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AnimalController))]

public class ScoreTracker : MonoBehaviour {

    public float score;
    public static ScoreTracker Instance;
    public Text ScoreText;
    public Text HighScoreText;
    private AnimalController animalController;


    // Use this for initialization
    void Start()
    {
        animalController = GetComponent<AnimalController>();
    }


    // Update is called once per frame
    void Update()
    {
        if (!animalController.AnimalRunning)
        {
            return;
        }
        score += Time.deltaTime;
        ScoreText.text = "" + score;
    }

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
            // update ScoreText in scene
            ScoreText.text = score.ToString();

            // checking whether current score is greater than value in PlayerPrefs
            if (PlayerPrefs.GetInt("HighScore") < score)
            {
                // update value in PlayerPrefs
                PlayerPrefs.SetFloat("HighScore", score);
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
