using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    public GameObject pauseMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {
             if (pauseMenu.activeSelf==false)
            {
              pauseMenu.SetActive(true);
                Time.timeScale = 0;
               }   

                   else{
                Continue();

            }
        } 
	}

    public void Continue ()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;


    } 

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Safari Run");
    }


    public void Quit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
        
    }
}

