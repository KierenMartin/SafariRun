using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(ScoreTracker))]


public class UnlockAnimalFacts : MonoBehaviour
{
    private const int FACT_COUNT = 3;
    private const string FACT_KEY = "FactUnlocked";
    private const string STRING_KEY = "Fact";
    private const string CONGRATS = "Well Done!  You unlocked an animal fact!";

    public int ScoreThreshold = 15;
    public string[] AnimalFacts;
    public Text[] FactDisplay;
    public GameObject Message;

    private ScoreTracker scoreTracker;
    private int scoreInt;
    private int unlockLevel = 0;

    void Start()
    {
        scoreTracker = GetComponent<ScoreTracker>();
        Message.gameObject.SetActive(false);

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
                unlockLevel = i + 1;
                FactDisplay[i].text = PlayerPrefs.GetString(STRING_KEY + i);
            }
        }
    }

    void Update()
    {
        scoreInt = scoreTracker.ScoreInt;
        if (unlockLevel < FACT_COUNT && scoreInt >= ScoreThreshold * (unlockLevel + 1))
        {
            Message.gameObject.SetActive(true);
            StartCoroutine(WaitForSec());
            PlayerPrefs.SetInt(FACT_KEY + unlockLevel, 1);
            FactDisplay[unlockLevel].text = AnimalFacts[unlockLevel];
            PlayerPrefs.SetString(STRING_KEY + unlockLevel, AnimalFacts[unlockLevel]);
            unlockLevel += 1;
        }
    }


    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Message.gameObject.SetActive(false);
    }
}

    

   

 