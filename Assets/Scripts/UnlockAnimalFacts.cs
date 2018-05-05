using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AnimalController))]


public class UnlockAnimalFacts : MonoBehaviour
{
    public Text FactOne, FactTwo, FactThree;
    public GameObject Message;
    public int ScoreInt;
   

    void Start()
    {
        ScoreInt = PlayerPrefs.GetInt("ScoreInt");
        Message.SetActive(false);
    }


    void Update()
    {
        ScoreInt = PlayerPrefs.GetInt("ScoreInt");

        if (ScoreInt == 10)
        {
            FactOne.text = "The White Rhinoceros can weigh over 3500 kg".ToString();
            Message.SetActive(true);
            StartCoroutine("WaitForSec");
        }

        if (ScoreInt == 20)
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
        yield return new WaitForSeconds(3);
        Destroy(Message);
    }
}

    

   

 