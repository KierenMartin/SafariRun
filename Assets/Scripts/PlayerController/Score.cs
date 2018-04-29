using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent (typeof(AnimalController))]
public class Score : MonoBehaviour {
    public Text scoreDisplay;

    private AnimalController animalController;
    private float points;

	// Use this for initialization
	void Start () {
        animalController = GetComponent<AnimalController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!animalController.AnimalRunning)
        {
            return;
        }
        points += Time.deltaTime;
        scoreDisplay.text = "" + points;
	}
}
