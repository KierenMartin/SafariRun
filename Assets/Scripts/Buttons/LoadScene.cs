using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
   
        public void NextScene(string scenename)
        {
            SceneManager.LoadScene(scenename);
        }
    }