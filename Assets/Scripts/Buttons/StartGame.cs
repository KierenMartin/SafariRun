using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
    public GameObject animalFacts;
    public GameObject highScore;
    public Text buttonLabel;
    public Text[] FactDisplay;

    private const int FACT_COUNT = 3;
    private const string FACT_KEY = "FactUnlocked";
    private const string STRING_KEY = "Fact";

    private bool showHighScore = true;

    private void Start()
    {
        displayHighScore();
        initialiseFacts();
    }

    private void initialiseFacts()
    {
        for (var i = 0; i < FACT_COUNT; i++)
        {
            var key = FACT_KEY + i;

            if (!PlayerPrefs.HasKey(key))
            {
                PlayerPrefs.SetInt(key, 0);
            }
            else if (PlayerPrefs.GetInt(key) == 1)
            {
                Debug.Log("Loading fact");
                FactDisplay[i].text = PlayerPrefs.GetString(STRING_KEY + i);
            }
        }
    }

    public void NextScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void ToggleDisplayBoard()
    {
        if (showHighScore)
        {
            displayAnimalFacts();
        }
        else
        {
            displayHighScore();
        }

        showHighScore = !showHighScore;
    }

    private void displayAnimalFacts()
    {
        animalFacts.SetActive(true);
        highScore.SetActive(false);
        buttonLabel.text = "High Scores";
    }

    private void displayHighScore()
    {
        animalFacts.SetActive(false);
        highScore.SetActive(true);
        buttonLabel.text = "Animal Facts";
    }
}