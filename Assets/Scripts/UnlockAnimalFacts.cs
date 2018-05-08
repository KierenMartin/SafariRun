using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(ScoreTracker))]


public class UnlockAnimalFacts : MonoBehaviour
{
    public Text FactOne, FactTwo, FactThree;
    public GameObject Message;
    public int ScoreInt;
   

<<<<<<< HEAD
    private float score;
    private ScoreTracker scoreTracker;
    int scoreInt;
    public Text FactOne;

    // Use this for initialization
    void Start()
    {
        scoreTracker = GetComponent<ScoreTracker>(); 
=======
    void Start()
    {
        ScoreInt = PlayerPrefs.GetInt("ScoreInt");
        Message.SetActive(false);
>>>>>>> Finella2
    }


    void Update()
    {
<<<<<<< HEAD
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
=======
        ScoreInt = PlayerPrefs.GetInt("ScoreInt");

        if (ScoreInt == 10)
        {
            FactOne.text = "The White Rhinoceros can weigh over 3500 kg".ToString();
            Message.SetActive(true);
            StartCoroutine("WaitForSec");
        }

        if (ScoreInt == 20)
>>>>>>> Finella2
        {
            FactTwo.text = "Rhinoceros are often hunted by humans for their horns".ToString();
            Message.SetActive(true);
            StartCoroutine("WaitForSec");
        }

        if (ScoreInt == 30)
        {
            FactThree.text = "White Rhinoceros are grey in colour despite their name".ToString();
            Message.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }


    IEnumerator WaitForSec()
    {
<<<<<<< HEAD
        if (ScoreInt == 10)
        {
            FactOne.text = "Animal Fact Unlocked";  
        }
    }*/
=======
        yield return new WaitForSeconds(3);
        Message.SetActive(false);
    }
>>>>>>> Finella2
}

    

   

 