using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {

	// Use this for initialization
	void OnGUI()
    {
		if (GUI.Button (new Rect (Screen.width - ((Screen.width / 60)) - (Screen.width / 20), Screen.height / 60, Screen.width / 20, Screen.width / 20), "Rt"))
	    {
             Application.LoadLevel(Application.loadedLevel); 
    
        }  
    }
    
        
}    

